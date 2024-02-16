using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailScale
{
    public partial class treni : UserControl
    {
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\source\repos\RailScale\RailScale\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");
        char direzioneTreno;
        DataTable trenoDT = new DataTable();

        public treni()
        {
            InitializeComponent();
        }

        private void treni_Load(object sender, EventArgs e)
        {
            //RIEMPIO LA DATAGRIDVIEW1 E LA COMBOBOX TRACCIA TRENO CON I TRENI 
            pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno", trenoDT, connetti, dataGridView1);
            TracciaTrenoCB.DataSource = trenoDT;
            TracciaTrenoCB.DisplayMember = "Traccia";
            TracciaTrenoCB.ValueMember = "ID Treno";
            TracciaTrenoCB.SelectedIndex = 0;
            
            //RIEMPIO LA DATAGRIDVIEW2 CON LA LISTA DEI CARRI PER OGNI SINGOLO TRENO SELEZIONATO
            dettagliTreno((int)TracciaTrenoCB.SelectedValue, dataGridView2);
        }

        public void Refresh()
        {
            pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno", trenoDT, connetti, dataGridView1);

            TracciaTrenoCB.DataSource = trenoDT;
        }

        public void dettagliTreno(int idTreno, DataGridView dataGrid)
        {
            if (connetti.State != ConnectionState.Open)
            {
                try
                {
                    connetti.Open();

                    DataTable detailsTreno = new DataTable();

                    string selectedTrain = "SELECT a_p FROM treno WHERE id = @idTreno";

                    using (SqlCommand cmd = new SqlCommand(selectedTrain, connetti))
                    {
                        cmd.Parameters.AddWithValue("@idTreno", idTreno);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            string direzioneTreno = reader["a_p"].ToString();
                            reader.Close();
                            //POICHE' NON RIESCO A CONVERTIRE LA STRINGA READER['a_p'] IN CHAR PRENDO IL PRIMO CARATTERE COSI
                            if (direzioneTreno[0] == 'A')
                            {
                                string query = "select carro.targa as \'Targa Carro\', carro.peso_in as \'Peso\', prodotto.nome as \'Prodotto\'"+
                                    " from treno inner join carro on carro.treno_in = treno.id" +
                                    " inner join prodotto on carro.prodotto = prodotto.id " +
                                    " where treno.id = " + Convert.ToString(idTreno);
                                
                                SqlCommand comando = new SqlCommand(query, connetti);

                                SqlDataReader leggi = comando.ExecuteReader();

                                detailsTreno.Load(leggi);

                                dataGrid.DataSource = detailsTreno;

                                query = "select sum(carro.peso_in) as \'Peso\' " + 
                                        "from treno inner join carro on carro.treno_in = treno.id" +
                                        " where treno.id = " + Convert.ToString(idTreno);

                                comando = new SqlCommand(query, connetti);
                                leggi = comando.ExecuteReader();
                                if(leggi.HasRows)
                                {
                                    leggi.Read();
                                    pesoTreno.Text = leggi["Peso"].ToString() + " Kg";
                                    pesoProdotto.Text = "Carri Vuoti";
                                    leggi.Close();
                                }
                                
                            }
                            else
                            {
                                string query = "select carro.targa as \'Targa Carro\', carro.peso_out as \'Peso\', prodotto.nome as \'Prodotto\'" + 
                                    " from treno inner join carro on carro.treno_out = treno.id" + 
                                    " inner join prodotto on carro.prodotto = prodotto.id " +
                                    " where treno.id = " + Convert.ToString(idTreno);
                                
                                SqlCommand comando = new SqlCommand(query, connetti);

                                SqlDataReader leggi = comando.ExecuteReader();

                                detailsTreno.Load(leggi);

                                dataGrid.DataSource = detailsTreno;

                                query = "select sum(carro.peso_out) as \'Peso Treno\', abs(sum(carro.peso_out - carro.peso_in)) as \'Peso Prodotto\'" +
                                        "from treno inner join carro on carro.treno_out = treno.id" +
                                        " where treno.id = " + Convert.ToString(idTreno);

                                comando = new SqlCommand(query, connetti);
                                leggi = comando.ExecuteReader();
                                if (leggi.HasRows)
                                {
                                    leggi.Read();
                                    pesoTreno.Text = leggi["Peso Treno"].ToString() + " Kg";
                                    pesoProdotto.Text = leggi["Peso Prodotto"].ToString() + " Kg";
                                    leggi.Close();
                                }

                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore" + ex, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connetti.Close();
                }
            }
           
        }

        private void addTrain_Click(object sender, EventArgs e)
        {
            if (TracciaTrenoCB.Text == "" || PartenzaTB.Text == ""
                || ArrivoTB.Text == "" || direzioneTreno != 'A' && direzioneTreno != 'P')
            {
                MessageBox.Show("Per favore inserisci tutti i dati", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(TracciaTrenoCB.Text, out int traccia))
                {
                    if (connetti.State != ConnectionState.Open)
                    {
                        try
                        {
                            connetti.Open();

                            string selectTrain = "SELECT COUNT(ID) FROM treno WHERE traccia = @traccia";

                            using (SqlCommand check = new SqlCommand(selectTrain, connetti))
                            {
                                check.Parameters.AddWithValue("@traccia", traccia.ToString());

                                int count = (int)check.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show("E' già stato registrato con lo stesso treno.",
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "INSERT INTO treno" +
                                        "(partenza, arrivo, data, a_p, traccia)" +
                                        "VALUES(@partenza, @arrivo, @data, @a_p, @traccia)";

                                    using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                    {
                                        comando.Parameters.AddWithValue("@partenza", PartenzaTB.Text.Trim());
                                        comando.Parameters.AddWithValue("@arrivo", ArrivoTB.Text.Trim());
                                        comando.Parameters.AddWithValue("@data", dateTimeTreno.Value);
                                        comando.Parameters.AddWithValue("@a_p", direzioneTreno);
                                        comando.Parameters.AddWithValue("@traccia", Convert.ToInt32(TracciaTrenoCB.Text.Trim()));

                                        comando.ExecuteNonQuery();

                                        connetti.Close();
                                        // AGGIORNO LA DATAGRID
                                        pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno", trenoDT, connetti, dataGridView1);
                                        TracciaTrenoCB.DataSource = trenoDT;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore" + ex, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connetti.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Errore di sintassi nel campo \'Numero di traccia\'.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
        }

        private void ArrivoRBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Treno segnalato come 'In Arrivo'
            direzioneTreno = 'A';
        }

        private void PartenzaRBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Treno segnalato come 'In Partenza'
            direzioneTreno = 'P';
        }

        private void deleteTrain_Click(object sender, EventArgs e)
        {
            if (TracciaTrenoCB.Text == "")
            {
                MessageBox.Show("Seleziona il treno da cancellare.", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Sei sicuro di voler cancellare il treno?\n Cancellerai tutti i carri ad esso associato.", "Messaggio di conferma",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connetti.State != ConnectionState.Open)
                    {
                        try
                        {
                            connetti.Open();

                            string selectedTrain = "SELECT COUNT(ID) FROM treno WHERE id = @id";

                            using (SqlCommand checkTrain = new SqlCommand(selectedTrain, connetti))
                            {
                                checkTrain.Parameters.AddWithValue("@id", (int)TracciaTrenoCB.SelectedValue);

                                int count = (int)checkTrain.ExecuteScalar();

                                if (count < 1)
                                {
                                    MessageBox.Show("Il treno non è stato trovato.",
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "DELETE FROM treno WHERE id = @id";

                                    using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                    {
                                        comando.Parameters.AddWithValue("@id", (int)TracciaTrenoCB.SelectedValue);

                                        comando.ExecuteNonQuery();

                                        connetti.Close();
                                        // AGGIORNO LA DATAGRID
                                        pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno", trenoDT, connetti, dataGridView1);
                                        TracciaTrenoCB.DataSource = trenoDT;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore" + ex, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connetti.Close();
                        }
                    }
                }
            }
        }

        private void TracciaTrenoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TracciaTrenoCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //AGGIORNO LA DATAGRIDVIEW2 QUANDO VIENE SELEZIONATO UN'ALTRA TRACCIA TRENO 
            dettagliTreno((int)TracciaTrenoCB.SelectedValue, dataGridView2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dettagliTreno((int)TracciaTrenoCB.SelectedValue, dataGridView2);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dettagliTreno((int)TracciaTrenoCB.SelectedValue, dataGridView2);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dettagliTreno((int)TracciaTrenoCB.SelectedValue, dataGridView2);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

