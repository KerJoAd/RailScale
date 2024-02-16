using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailScale
{

    public partial class loginForm : Form
    {
        //passo l'indirizzo del database all'oggetto 'connetti' 
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\OneDrive\Documenti\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");

        public static class nomeUtente
        {
            public static string nome;
        }
    
        public loginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)  // NON TROVO IL MODO DI CAMBIARE IL NOME A QUESTO LABEL - NOME CORRETTO: 'exitForm'
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void butAccedi_Click(object sender, EventArgs e)
        {
            if (emailLogIn.Text == "" || passwordLogIn.Text == "")
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

                        string query = "SELECT password, nome FROM utenti WHERE email = @email";

                        using (SqlCommand cmd = new SqlCommand(query, connetti))
                        {
                            cmd.Parameters.AddWithValue("@email",emailLogIn.Text.Trim());

                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {

                                reader.Read();
                                string risposta = reader["password"].ToString();
                                nomeUtente.nome = reader["nome"].ToString();
                                reader.Close();

                                if (risposta != passwordLogIn.Text.Trim())
                                {
                                    MessageBox.Show("La Password inserita non è corretta.", "Errore",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {                                  
                                    mainForm main = new mainForm();
                                    main.Show();                                    
                                    this.Hide();
                                }                                
                            }
                            else 
                            {
                                MessageBox.Show("L'email inserita non è stata registrata.", "Errore",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void butIscriviti_Click(object sender, EventArgs e)
        {
            Form_register registratiForm = new Form_register();
            registratiForm.Show();
            this.Hide();
        }

        private void mostraPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordLogIn.PasswordChar = mostraPassword.Checked ? '\0' : '*';
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
    }
