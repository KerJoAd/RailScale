
namespace RailScale
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secPesa_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.rails_btn = new System.Windows.Forms.Button();
            this.carro_btn = new System.Windows.Forms.Button();
            this.saluta_utente = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pesatura2 = new RailScale.pesatura();
            this.secondaPesatura2 = new RailScale.secondaPesatura();
            this.treni2 = new RailScale.treni();
            this.prodotto2 = new RailScale.prodotto();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "RailScale";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(1071, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.secPesa_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.logOut);
            this.panel2.Controls.Add(this.products_btn);
            this.panel2.Controls.Add(this.rails_btn);
            this.panel2.Controls.Add(this.carro_btn);
            this.panel2.Controls.Add(this.saluta_utente);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 565);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // secPesa_btn
            // 
            this.secPesa_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.secPesa_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secPesa_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secPesa_btn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "secPesa_btn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.secPesa_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.secPesa_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.secPesa_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.secPesa_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secPesa_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secPesa_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secPesa_btn.Image = ((System.Drawing.Image)(resources.GetObject("secPesa_btn.Image")));
            this.secPesa_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.secPesa_btn.Location = new System.Drawing.Point(16, 288);
            this.secPesa_btn.Name = global::RailScale.Properties.Settings.Default.secPesa_btn;
            this.secPesa_btn.Size = new System.Drawing.Size(180, 45);
            this.secPesa_btn.TabIndex = 6;
            this.secPesa_btn.Text = "Seconda Pesata";
            this.secPesa_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.secPesa_btn.UseVisualStyleBackColor = false;
            this.secPesa_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(57, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Disconnetti";
            // 
            // logOut
            // 
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.logOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(16, 518);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(35, 35);
            this.logOut.TabIndex = 3;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // products_btn
            // 
            this.products_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.products_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.products_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.products_btn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "products_btn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.products_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.products_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.products_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.products_btn.Image = ((System.Drawing.Image)(resources.GetObject("products_btn.Image")));
            this.products_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_btn.Location = new System.Drawing.Point(16, 410);
            this.products_btn.Name = global::RailScale.Properties.Settings.Default.products_btn;
            this.products_btn.Size = new System.Drawing.Size(180, 45);
            this.products_btn.TabIndex = 5;
            this.products_btn.Text = "Prodotto";
            this.products_btn.UseVisualStyleBackColor = false;
            this.products_btn.Click += new System.EventHandler(this.prodotto_Click);
            // 
            // rails_btn
            // 
            this.rails_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.rails_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rails_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rails_btn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "rails_btn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rails_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.rails_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.rails_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.rails_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rails_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rails_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rails_btn.Image = ((System.Drawing.Image)(resources.GetObject("rails_btn.Image")));
            this.rails_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rails_btn.Location = new System.Drawing.Point(16, 348);
            this.rails_btn.Name = global::RailScale.Properties.Settings.Default.rails_btn;
            this.rails_btn.Size = new System.Drawing.Size(180, 45);
            this.rails_btn.TabIndex = 4;
            this.rails_btn.Text = "Treni";
            this.rails_btn.UseVisualStyleBackColor = false;
            this.rails_btn.Click += new System.EventHandler(this.treni_Click);
            // 
            // carro_btn
            // 
            this.carro_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.carro_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.carro_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carro_btn.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "carro_btn", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.carro_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.carro_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.carro_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.carro_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carro_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carro_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carro_btn.Image = ((System.Drawing.Image)(resources.GetObject("carro_btn.Image")));
            this.carro_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carro_btn.Location = new System.Drawing.Point(16, 228);
            this.carro_btn.Name = global::RailScale.Properties.Settings.Default.carro_btn;
            this.carro_btn.Size = new System.Drawing.Size(180, 45);
            this.carro_btn.TabIndex = 3;
            this.carro_btn.Text = "Prima Pesata   ";
            this.carro_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carro_btn.UseVisualStyleBackColor = false;
            this.carro_btn.Click += new System.EventHandler(this.pesatura_Click);
            // 
            // saluta_utente
            // 
            this.saluta_utente.AutoSize = true;
            this.saluta_utente.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "saluta_utente", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.saluta_utente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saluta_utente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saluta_utente.Location = new System.Drawing.Point(17, 171);
            this.saluta_utente.Name = global::RailScale.Properties.Settings.Default.saluta_utente;
            this.saluta_utente.Size = new System.Drawing.Size(179, 22);
            this.saluta_utente.TabIndex = 3;
            this.saluta_utente.Text = "Benvenuto, Utente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pesatura2);
            this.panel3.Controls.Add(this.secondaPesatura2);
            this.panel3.Controls.Add(this.treni2);
            this.panel3.Controls.Add(this.prodotto2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 565);
            this.panel3.TabIndex = 3;
            // 
            // pesatura2
            // 
            this.pesatura2.Location = new System.Drawing.Point(0, 0);
            this.pesatura2.Name = "pesatura2";
            this.pesatura2.Size = new System.Drawing.Size(875, 565);
            this.pesatura2.TabIndex = 3;
            this.pesatura2.Load += new System.EventHandler(this.pesatura2_Load_1);
            // 
            // secondaPesatura2
            // 
            this.secondaPesatura2.Location = new System.Drawing.Point(0, 0);
            this.secondaPesatura2.Name = "secondaPesatura2";
            this.secondaPesatura2.Size = new System.Drawing.Size(875, 565);
            this.secondaPesatura2.TabIndex = 2;
            // 
            // treni2
            // 
            this.treni2.Location = new System.Drawing.Point(0, 0);
            this.treni2.Name = "treni2";
            this.treni2.Size = new System.Drawing.Size(875, 565);
            this.treni2.TabIndex = 1;
            // 
            // prodotto2
            // 
            this.prodotto2.Location = new System.Drawing.Point(0, -3);
            this.prodotto2.Name = "prodotto2";
            this.prodotto2.Size = new System.Drawing.Size(875, 565);
            this.prodotto2.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button carro_btn;
        private System.Windows.Forms.Label saluta_utente;
        private System.Windows.Forms.Button rails_btn;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button secPesa_btn;
        private prodotto prodotto2;
        private treni treni2;
        private secondaPesatura secondaPesatura2;
        private pesatura pesatura2;
    }
            
}