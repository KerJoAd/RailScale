using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailScale
{

    public partial class secondaPesatura : UserControl
    {
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\source\repos\RailScale\RailScale\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable carroDT = new DataTable();
        DataTable trenoDT = new DataTable();
        public secondaPesatura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxIdCarro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secondaPesatura_Load(object sender, EventArgs e)
        {
            pesatura.itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);

            comboBoxIdCarro.DataSource = carroDT;
            comboBoxIdCarro.DisplayMember = "ID Carro";
            comboBoxIdCarro.ValueMember = "ID Carro";

            pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno where a_p = \'P\'", trenoDT, connetti, dataGridView2);
            dataGridView2.Columns["ID Treno"].Visible = false;

            comboBoxIdTreno.DataSource = trenoDT;
            comboBoxIdTreno.DisplayMember = "Traccia";
            comboBoxIdTreno.ValueMember = "ID Treno";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editCarro_Click(object sender, EventArgs e)
        {
            if (comboBoxIdCarro.Text == "" || comboBoxIdTreno.Text == "" || textBoxPeso.Text == "")
            {
                MessageBox.Show("Per favore inserisci tutti i dati", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.TryParse(textBoxPeso.Text, out int pesoOut))
                {
                    if (connetti.State != ConnectionState.Open)
                    {
                        try
                        {
                            connetti.Open();

                            string selectUsername = "SELECT COUNT(ID) FROM carro WHERE id = @id";

                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connetti))
                            {
                                checkUser.Parameters.AddWithValue("@id", (int)comboBoxIdCarro.SelectedValue);

                                int count = (int)checkUser.ExecuteScalar();

                                if (count < 1)
                                {
                                    MessageBox.Show("Il carro non è stato trovato.",
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    string insertData = "UPDATE carro SET treno_out = @treno, peso_out = @peso WHERE id = @id";

                                    using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                    {
                                        comando.Parameters.AddWithValue("@peso", pesoOut);
                                        comando.Parameters.AddWithValue("@treno", (int)comboBoxIdTreno.SelectedValue);
                                        comando.Parameters.AddWithValue("@id", (int)comboBoxIdCarro.SelectedValue);

                                        comando.ExecuteNonQuery();

                                        connetti.Close();
                                        // AGGIORNO LA DATAGRID                               
                                        pesatura.itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);
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
                    MessageBox.Show("Errore di sintassi nel campo del peso.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancCarro_Click(object sender, EventArgs e)
        {
            if (comboBoxIdCarro.Text == "")
            {
                MessageBox.Show("Seleziona un carro da cancellare.", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (connetti.State != ConnectionState.Open)
                {
                    try
                    {
                        connetti.Open();

                        string selectedWagon = "SELECT COUNT(ID) FROM carro WHERE id = @id";

                        using (SqlCommand check = new SqlCommand(selectedWagon, connetti))
                        {
                            check.Parameters.AddWithValue("@id", (int)comboBoxIdCarro.SelectedValue);

                            int count = (int)check.ExecuteScalar();

                            if (count < 1)
                            {
                                MessageBox.Show("Il carro non è stato trovato.",
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "DELETE FROM carro WHERE id = @id";

                                using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                {
                                    comando.Parameters.AddWithValue("@id", (int)comboBoxIdCarro.SelectedValue);

                                    comando.ExecuteNonQuery();

                                    connetti.Close();
                                    // AGGIORNO LA DATAGRID E LA COMBOBOX ID_CARRO
                                    pesatura.itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);

                                    comboBoxIdCarro.DataSource = carroDT;
                                    comboBoxIdCarro.DisplayMember = "ID Carro";
                                    comboBoxIdCarro.ValueMember = "ID Carro";
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

        public void Refresh()
        {
            pesatura.itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);

            comboBoxIdCarro.DataSource = carroDT;            

            pesatura.itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno where a_p = \'P\'", trenoDT, connetti, dataGridView2);

            comboBoxIdTreno.DataSource = trenoDT;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
