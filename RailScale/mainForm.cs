using System;
using System.Windows.Forms;

namespace RailScale
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prodotto_Click(object sender, EventArgs e)
        {
            pesatura2.Visible = false;       
            secondaPesatura2.Visible = false;
            treni2.Visible = false;
            prodotto2.Visible = true;
            prodotto2.Refresh();
        }

        private void treni_Click(object sender, EventArgs e)
        {
            pesatura2.Visible = false;            
            secondaPesatura2.Visible = false;
            treni2.Visible = true;
            treni2.Refresh();
            prodotto2.Visible = false;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Sei sicuro di volerti disconnettere?", "Messaggio di conferma",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                loginForm formLogin = new loginForm();
                formLogin.Show();
                this.Hide();
            }

        }

        private void pesatura_Click(object sender, EventArgs e)
        {
            pesatura2.Visible = true;
            pesatura2.Refresh();
            secondaPesatura2.Visible = false;
            treni2.Visible = false;
            prodotto2.Visible = false;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesatura2.Visible = false;
            secondaPesatura2.Visible = true;
            secondaPesatura2.Refresh();
            treni2.Visible = false;
            prodotto2.Visible = false;
        }

        private void pesatura2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            saluta_utente.Text = "Benvenuto, " + loginForm.nomeUtente.nome;
        }

        private void pesatura2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
