
namespace RailScale
{
    partial class loginForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butIscriviti = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emailLogIn = new System.Windows.Forms.TextBox();
            this.passwordLogIn = new System.Windows.Forms.TextBox();
            this.mostraPassword = new System.Windows.Forms.CheckBox();
            this.butAccediLogIn = new System.Windows.Forms.Button();
            this.exitForm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.butIscriviti);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 400);
            this.panel1.TabIndex = 0;
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
            // butIscriviti
            // 
            this.butIscriviti.BackColor = System.Drawing.Color.WhiteSmoke;
            this.butIscriviti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butIscriviti.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "butIscriviti", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.butIscriviti.FlatAppearance.BorderSize = 0;
            this.butIscriviti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butIscriviti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.butIscriviti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butIscriviti.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIscriviti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.butIscriviti.Location = new System.Drawing.Point(25, 327);
            this.butIscriviti.Name = global::RailScale.Properties.Settings.Default.butIscriviti;
            this.butIscriviti.Size = new System.Drawing.Size(194, 38);
            this.butIscriviti.TabIndex = 8;
            this.butIscriviti.Text = "Iscriviti";
            this.butIscriviti.UseVisualStyleBackColor = false;
            this.butIscriviti.Click += new System.EventHandler(this.butIscriviti_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(56, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Registra il tuo account";
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accedi al tuo account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password :";
            // 
            // emailLogIn
            // 
            this.emailLogIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLogIn.Location = new System.Drawing.Point(282, 150);
            this.emailLogIn.Multiline = true;
            this.emailLogIn.Name = "emailLogIn";
            this.emailLogIn.Size = new System.Drawing.Size(263, 30);
            this.emailLogIn.TabIndex = 5;
            this.emailLogIn.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // passwordLogIn
            // 
            this.passwordLogIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLogIn.Location = new System.Drawing.Point(282, 227);
            this.passwordLogIn.Name = "passwordLogIn";
            this.passwordLogIn.PasswordChar = '*';
            this.passwordLogIn.Size = new System.Drawing.Size(263, 26);
            this.passwordLogIn.TabIndex = 6;
            this.passwordLogIn.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // mostraPassword
            // 
            this.mostraPassword.AutoSize = true;
            this.mostraPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostraPassword.Location = new System.Drawing.Point(438, 263);
            this.mostraPassword.Name = "mostraPassword";
            this.mostraPassword.Size = new System.Drawing.Size(108, 17);
            this.mostraPassword.TabIndex = 8;
            this.mostraPassword.Text = "Mostra Password";
            this.mostraPassword.UseVisualStyleBackColor = true;
            this.mostraPassword.CheckedChanged += new System.EventHandler(this.mostraPassword_CheckedChanged);
            // 
            // butAccediLogIn
            // 
            this.butAccediLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.butAccediLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAccediLogIn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "butAccedi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.butAccediLogIn.FlatAppearance.BorderSize = 0;
            this.butAccediLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.butAccediLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.butAccediLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAccediLogIn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAccediLogIn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butAccediLogIn.Location = new System.Drawing.Point(282, 284);
            this.butAccediLogIn.Name = global::RailScale.Properties.Settings.Default.butAccedi;
            this.butAccediLogIn.Size = new System.Drawing.Size(109, 41);
            this.butAccediLogIn.TabIndex = 7;
            this.butAccediLogIn.Text = "Accedi";
            this.butAccediLogIn.UseVisualStyleBackColor = false;
            this.butAccediLogIn.Click += new System.EventHandler(this.butAccedi_Click);
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
            this.exitForm.TabIndex = 1;
            this.exitForm.Text = "X";
            this.exitForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.mostraPassword);
            this.Controls.Add(this.butAccediLogIn);
            this.Controls.Add(this.passwordLogIn);
            this.Controls.Add(this.emailLogIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailLogIn;
        private System.Windows.Forms.TextBox passwordLogIn;
        private System.Windows.Forms.Button butAccediLogIn;
        private System.Windows.Forms.CheckBox mostraPassword;
        private System.Windows.Forms.Button butIscriviti;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

