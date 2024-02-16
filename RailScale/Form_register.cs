using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RailScale
{
    public partial class Form_register : Form
    {
        //passo l'indirizzo del database all'oggetto 'connetti' 
        SqlConnection connetti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ISAAC\OneDrive\Documenti\Ferrovia.mdf;Integrated Security=True;Connect Timeout=30");


        public Form_register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butAccedi_Click(object sender, EventArgs e) //non riesco a cambiare il nome della classe in 'butRegistraReg'
        {
            //controllo che l'utente abbia inserito tutti i dati
            if (nomeReg.Text =="" || cognomeReg.Text =="" || emailReg.Text == "" || passwordReg.Text == "" || ctrlPasswordReg.Text =="")
            {
                MessageBox.Show("Per favore inserisci tutti i dati", "Errore", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //controllo che i campi 'password' e 'controllo password' siano identici
                if (passwordReg.Text != ctrlPasswordReg.Text)
                {
                    MessageBox.Show("I campi \"Password\" e \"Controllo Password\" non sono uguali.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //ora controllo lo stato della connessione con il DB
                    if (connetti.State != ConnectionState.Open)
                    {
                        try
                        {
                            connetti.Open();

                            //controllo che non sia già presente nel DB la mail dell'utente
                            string selectUsername = "SELECT COUNT(ID) FROM utenti WHERE email = @email";

                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connetti))
                            {
                                checkUser.Parameters.AddWithValue("@email", emailReg.Text.Trim());
                                int count = (int)checkUser.ExecuteScalar();

                                if (count >= 1)
                                {
                                    //se è presente 
                                    MessageBox.Show("\"" + emailReg.Text.Trim() + "\"" + " è già stato registrato nel sistema",
                                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    //preparo la stringa con la query di inserimento
                                    string insertData = "INSERT INTO utenti" +
                                        "(nome, cognome, email, password)" +
                                        "VALUES(@nome, @cognome, @email, @password)";

                                    //passo i dati alla classe 'comando'
                                    using (SqlCommand comando = new SqlCommand(insertData, connetti))
                                    {
                                        comando.Parameters.AddWithValue("@nome", nomeReg.Text.Trim());
                                        comando.Parameters.AddWithValue("@cognome", cognomeReg.Text.Trim());
                                        comando.Parameters.AddWithValue("@email", emailReg.Text.Trim());
                                        comando.Parameters.AddWithValue("@password", passwordReg.Text.Trim());

                                        //eseguo la query
                                        comando.ExecuteNonQuery();

                                        //mando a schermo un messaggio di avvenuta registrazione 
                                        MessageBox.Show("Ti sei registrato con successo!",
                                            "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //passo la linea al form di Log In
                                        loginForm accediForm = new loginForm();
                                        accediForm.Show();
                                        this.Hide();
                                    }
                                }
                            }


                        }
                        catch (Exception ex)
                        {
                            //se c'è stato qualche problema mando a schermo messaggio di errore
                            MessageBox.Show("Errore" + ex, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            //alla fine chiedo connessione con DB
                            connetti.Close();
                        }
                    }
                }
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_register_Load(object sender, EventArgs e)
        {

        }

        private void butAccedi_Click_1(object sender, EventArgs e)
        {
            loginForm accediForm = new loginForm();
            accediForm.Show();
            this.Hide();
        }

        private void mostraPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordReg.PasswordChar = mostraPassword.Checked ? '\0' : '*';
            ctrlPasswordReg.PasswordChar = mostraPassword.Checked ? '\0' : '*';
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
