
namespace RailScale
{
    partial class Form_register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_register));
            this.mostraPassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butAccedi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ctrlPasswordReg = new System.Windows.Forms.TextBox();
            this.emailReg = new System.Windows.Forms.TextBox();
            this.cognomeReg = new System.Windows.Forms.TextBox();
            this.exitForm = new System.Windows.Forms.Label();
            this.butRegistra = new System.Windows.Forms.Button();
            this.passwordReg = new System.Windows.Forms.TextBox();
            this.nomeReg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mostraPassword
            // 
            this.mostraPassword.AutoSize = true;
            this.mostraPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostraPassword.Location = new System.Drawing.Point(433, 315);
            this.mostraPassword.Name = "mostraPassword";
            this.mostraPassword.Size = new System.Drawing.Size(108, 17);
            this.mostraPassword.TabIndex = 16;
            this.mostraPassword.Text = "Mostra Password";
            this.mostraPassword.UseVisualStyleBackColor = true;
            this.mostraPassword.CheckedChanged += new System.EventHandler(this.mostraPassword_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registra il tuo account";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butAccedi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 400);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // butAccedi
            // 
            this.butAccedi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butAccedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAccedi.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "Accedi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.butAccedi.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "but_Accedi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.butAccedi.FlatAppearance.BorderSize = 0;
            this.butAccedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butAccedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butAccedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAccedi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAccedi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.butAccedi.Location = new System.Drawing.Point(25, 327);
            this.butAccedi.Name = global::RailScale.Properties.Settings.Default.but_Accedi;
            this.butAccedi.Size = new System.Drawing.Size(194, 38);
            this.butAccedi.TabIndex = 8;
            this.butAccedi.Text = global::RailScale.Properties.Settings.Default.Accedi;
            this.butAccedi.UseVisualStyleBackColor = false;
            this.butAccedi.Click += new System.EventHandler(this.butAccedi_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(56, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Entra nel tuo account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gestionale dei carri ferroviari";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(68, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "RailScale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cognome :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(278, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Conferma Password :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ctrlPasswordReg
            // 
            this.ctrlPasswordReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "ctrlPassReg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ctrlPasswordReg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPasswordReg.Location = new System.Drawing.Point(281, 279);
            this.ctrlPasswordReg.Name = "ctrlPasswordReg";
            this.ctrlPasswordReg.PasswordChar = '*';
            this.ctrlPasswordReg.Size = new System.Drawing.Size(260, 26);
            this.ctrlPasswordReg.TabIndex = 23;
            this.ctrlPasswordReg.Text = global::RailScale.Properties.Settings.Default.ctrlPassReg;
            // 
            // emailReg
            // 
            this.emailReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "emailReg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.emailReg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailReg.Location = new System.Drawing.Point(281, 181);
            this.emailReg.Name = "emailReg";
            this.emailReg.Size = new System.Drawing.Size(260, 26);
            this.emailReg.TabIndex = 21;
            this.emailReg.Text = global::RailScale.Properties.Settings.Default.emailReg;
            // 
            // cognomeReg
            // 
            this.cognomeReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "cognomeReg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cognomeReg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognomeReg.Location = new System.Drawing.Point(281, 131);
            this.cognomeReg.Name = "cognomeReg";
            this.cognomeReg.Size = new System.Drawing.Size(260, 26);
            this.cognomeReg.TabIndex = 19;
            this.cognomeReg.Text = global::RailScale.Properties.Settings.Default.cognomeReg;
            // 
            // exitForm
            // 
            this.exitForm.AutoSize = true;
            this.exitForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitForm.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "exit", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.exitForm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitForm.Location = new System.Drawing.Point(545, 9);
            this.exitForm.Name = global::RailScale.Properties.Settings.Default.exit;
            this.exitForm.Size = new System.Drawing.Size(18, 18);
            this.exitForm.TabIndex = 17;
            this.exitForm.Text = "X";
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // butRegistra
            // 
            this.butRegistra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.butRegistra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRegistra.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "butRegistra", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.butRegistra.FlatAppearance.BorderSize = 0;
            this.butRegistra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.butRegistra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.butRegistra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegistra.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegistra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butRegistra.Location = new System.Drawing.Point(281, 335);
            this.butRegistra.Name = global::RailScale.Properties.Settings.Default.butRegistra;
            this.butRegistra.Size = new System.Drawing.Size(102, 31);
            this.butRegistra.TabIndex = 15;
            this.butRegistra.Text = "Registrati";
            this.butRegistra.UseVisualStyleBackColor = false;
            this.butRegistra.Click += new System.EventHandler(this.butAccedi_Click);
            // 
            // passwordReg
            // 
            this.passwordReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "passReg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordReg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordReg.Location = new System.Drawing.Point(281, 229);
            this.passwordReg.Name = "passwordReg";
            this.passwordReg.PasswordChar = '*';
            this.passwordReg.Size = new System.Drawing.Size(260, 26);
            this.passwordReg.TabIndex = 14;
            this.passwordReg.Text = global::RailScale.Properties.Settings.Default.passReg;
            this.passwordReg.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // nomeReg
            // 
            this.nomeReg.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RailScale.Properties.Settings.Default, "nomeReg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nomeReg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeReg.Location = new System.Drawing.Point(281, 78);
            this.nomeReg.Name = "nomeReg";
            this.nomeReg.Size = new System.Drawing.Size(260, 26);
            this.nomeReg.TabIndex = 13;
            this.nomeReg.Text = global::RailScale.Properties.Settings.Default.nomeReg;
            // 
            // Form_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.ctrlPasswordReg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailReg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cognomeReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.mostraPassword);
            this.Controls.Add(this.butRegistra);
            this.Controls.Add(this.passwordReg);
            this.Controls.Add(this.nomeReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_register";
            this.Load += new System.EventHandler(this.Form_register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mostraPassword;
        private System.Windows.Forms.Button butRegistra;
        private System.Windows.Forms.TextBox passwordReg;
        private System.Windows.Forms.TextBox nomeReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butAccedi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label exitForm;
        private System.Windows.Forms.TextBox cognomeReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailReg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ctrlPasswordReg;
        private System.Windows.Forms.Label label9;
    }
}