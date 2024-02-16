using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace RailScale
{
    public partial class pesatura : UserControl
    {
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\source\repos\RailScale\RailScale\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");

        DataTable carroDT = new DataTable();
        DataTable prodottoDT = new DataTable();
        DataTable trenoDT = new DataTable();

        public pesatura()
        {
            InitializeComponent();
        }

        private void pesatura_Load(object sender, EventArgs e)
        {
            itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);

            itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno where a_p = \'A\'", trenoDT, connetti, dataGridView2);
            dataGridView2.Columns["ID Treno"].Visible = false;

            itemsCB("SELECT * FROM prodotto", prodottoDT, connetti, comboBoxProdotto);            
            comboBoxProdotto.DisplayMember = "codice";
            comboBoxProdotto.ValueMember = "id";
            comboBoxProdotto.SelectedIndex = 0;            

            comboBoxTreno.DataSource = trenoDT;
            comboBoxTreno.DisplayMember = "Traccia";
            comboBoxTreno.ValueMember = "ID Treno";

        }


        public void Refresh()
        {
            itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);

            itemsDG("SELECT id as 'ID Treno', partenza as 'Partenza', arrivo as 'Destinazione\', data as 'Data', a_p as 'Arrivo o Partenza', traccia as 'Traccia' FROM treno where a_p = \'A\'", trenoDT, connetti, dataGridView2);

            itemsCB("SELECT * FROM prodotto", prodottoDT, connetti, comboBoxProdotto);

            comboBoxTreno.DataSource = trenoDT;
        }

        public static void itemsCB(string query, DataTable tabella, SqlConnection connessione, ComboBox box)
        {
            connessione.Open();

            tabella.Clear();

            SqlCommand cmd = new SqlCommand(query, connessione);

            SqlDataReader reader = cmd.ExecuteReader();

            tabella.Load(reader);

            box.DataSource = tabella;

            connessione.Close();
        }

        public static void itemsDG(string query, DataTable tabella, SqlConnection connessione, DataGridView griglia)
        {
            connessione.Open();

            tabella.Clear();

            SqlCommand cmd = new SqlCommand(query, connessione);

            SqlDataReader reader = cmd.ExecuteReader();

            tabella.Load(reader);

            griglia.DataSource = tabella;

            connessione.Close();
        }

        private void addCarro_Click(object sender, EventArgs e)
        {
            if (textBoxTarga.Text == "" || textBoxTLong.Text == ""
                || textBoxPortata.Text == "" || textBoxPesoIn.Text == "" ||
                comboBoxProdotto.Text == "" || comboBoxTreno.Text == "")
            {
                MessageBox.Show("Per favore inserisci tutti i dati", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(long.TryParse(textBoxTarga.Text, out long targa) &&
                int.TryParse(textBoxTLong.Text, out int tLong) &&
                int.TryParse(textBoxPesoIn.Text, out int pesoIn) &&
                float.TryParse(textBoxPortata.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture ,out float portata)
                )
                {                    
                    if (connetti.State != ConnectionState.Open)
                    {
                        try
                        {
                            connetti.Open();

                            string selectUsername = "SELECT COUNT(ID) FROM carro WHERE targa = @targa and treno_in = @treno";

                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connetti))
                            {
                                checkUser.Parameters.AddWithValue("@targa", targa.ToString());
                                checkUser.Parameters.AddWithValue("@treno", (int)comboBoxTreno.SelectedValue);

                                int count = (int)checkUser.ExecuteScalar();

                                if (count >= 1)
                                {
                                    MessageBox.Show("Il carro è già stato registrato con lo stesso treno in memoria.",
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {

                                    string insertData = "INSERT INTO carro" +
                                    "(treno_in, prodotto, targa, portata, t_long, peso_in)" +
                                    "VALUES(@treno, @prodotto, @targa, @portata, @t_long, @peso)";

                                    using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                    {
                                        comando.Parameters.AddWithValue("@portata", portata.ToString().Replace(',', '.')); //devo mettere questo replace perchè altrimenti crea problemi con la query mysql
                                        comando.Parameters.AddWithValue("@targa", targa.ToString());
                                        comando.Parameters.AddWithValue("@t_long", tLong.ToString());
                                        comando.Parameters.AddWithValue("@peso", pesoIn.ToString());
                                        comando.Parameters.AddWithValue("@treno", (int)comboBoxTreno.SelectedValue);
                                        comando.Parameters.AddWithValue("@prodotto", (int)comboBoxProdotto.SelectedValue);

                                        comando.ExecuteNonQuery();

                                        connetti.Close();
                                        // AGGIORNO LA DATAGRID
                                        itemsDG("SELECT carro.id as \'ID Carro\', t1.traccia as \'Treno In\', t2.traccia as \'Treno Out\', prodotto.nome as \'Prodotto\', carro.targa as \'Targa\', carro.t_long as \'T_Long\', carro.portata as \'Portata\', carro.peso_in as \'Peso In\', carro.peso_out as \'Peso Out\'FROM carro LEFT JOIN treno t1 ON carro.treno_in = t1.id LEFT JOIN treno t2 on carro.treno_out = t2.id LEFT JOIN prodotto on carro.prodotto = prodotto.id", carroDT, connetti, dataGridView1);
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
                    MessageBox.Show("Errore di Sintassi o Formato.\nScrivi il numero decimale con la virgola.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }           
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteInputs_Click(object sender, EventArgs e)
        {
            textBoxPesoIn.Clear();
            textBoxTarga.Clear();
            textBoxPortata.Clear();
            textBoxTLong.Clear();
        }

        private void textBoxPortata_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
