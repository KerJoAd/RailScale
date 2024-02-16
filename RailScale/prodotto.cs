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
    public partial class prodotto : UserControl
    {
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\source\repos\RailScale\RailScale\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable prodottoDT = new DataTable();

        public prodotto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prodotto_Load(object sender, EventArgs e)
        {
            pesatura.itemsDG("SELECT id, codice as \'Numero ONU\', nome as \'Denominazione\' FROM prodotto", prodottoDT, connetti, dataGridView1);           
            dataGridView1.Columns["id"].Visible = false;

            comboBoxAddProduct.DataSource = prodottoDT;
            comboBoxAddProduct.DisplayMember = "Numero Onu";
            comboBoxAddProduct.ValueMember = "id";
            comboBoxAddProduct.SelectedIndex = 0;
            
        }

        public void Refresh()
        {
            pesatura.itemsDG("SELECT id, codice as \'Numero ONU\', nome as \'Denominazione\' FROM prodotto", prodottoDT, connetti, dataGridView1);

            comboBoxAddProduct.DataSource = prodottoDT;
        }

        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxAddProduct.Text == "" || textBoxNameProduct.Text == "")
            {
                MessageBox.Show("Per favore inserisci tutti i dati", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connetti.State != ConnectionState.Open)
                {
                    try
                    {
                        connetti.Open();

                        string selectUsername = "SELECT COUNT(ID) FROM prodotto WHERE codice = @codice";

                        using (SqlCommand check = new SqlCommand(selectUsername, connetti))
                        {
                            check.Parameters.AddWithValue("@codice", comboBoxAddProduct.Text.Trim());                           

                            int count = (int)check.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Il prodotto è già presente in memoria.",
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO prodotto" +
                                    "(codice, nome)" +
                                    "VALUES(@codice, @nome)";

                                using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                {                                    
                                    comando.Parameters.AddWithValue("@codice", comboBoxAddProduct.Text.Trim());
                                    comando.Parameters.AddWithValue("@nome", textBoxNameProduct.Text.Trim());

                                    comando.ExecuteNonQuery();

                                    connetti.Close();
                                    // AGGIORNO LA DATAGRID
                                    pesatura.itemsDG("SELECT id, codice as \'Numero ONU\', nome as \'Denominazione\' FROM prodotto", prodottoDT, connetti, dataGridView1);
                                    dataGridView1.Columns["id"].Visible = false;
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

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxAddProduct.Text == "")
            {
                MessageBox.Show("Seleziona un prodotto da cancellare.", "Errore",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (connetti.State != ConnectionState.Open)
                {
                    try
                    {
                        connetti.Open();

                        string selectedProduct = "SELECT COUNT(ID) FROM prodotto WHERE codice = @codice";

                        using (SqlCommand checkUser = new SqlCommand(selectedProduct, connetti))
                        {
                            checkUser.Parameters.AddWithValue("@codice", comboBoxAddProduct.Text.Trim());

                            int count = (int)checkUser.ExecuteScalar();

                            if (count < 1)
                            {
                                MessageBox.Show("Il prodotto non è stato trovato.",
                                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "DELETE FROM prodotto WHERE codice = @codice";

                                using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                {
                                    comando.Parameters.AddWithValue("@codice", comboBoxAddProduct.Text.Trim());

                                    comando.ExecuteNonQuery();

                                    connetti.Close();

                                    pesatura.itemsDG("SELECT id, codice as \'Numero ONU\', nome as \'Denominazione\' FROM prodotto", prodottoDT, connetti, dataGridView1);
                                    dataGridView1.Columns["id"].Visible = false;
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
}
