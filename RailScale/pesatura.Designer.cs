
using System.ComponentModel;

namespace RailScale
{
    partial class pesatura
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxProdotto = new System.Windows.Forms.ComboBox();
            this.comboBoxTreno = new System.Windows.Forms.ComboBox();
            this.deleteInputs = new System.Windows.Forms.Button();
            this.addCarro = new System.Windows.Forms.Button();
            this.textBoxPesoIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTLong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPortata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTarga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 338);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 214);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(801, 106);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(801, 143);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Treni in arrivo :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista dei Carri :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxProdotto);
            this.panel2.Controls.Add(this.comboBoxTreno);
            this.panel2.Controls.Add(this.deleteInputs);
            this.panel2.Controls.Add(this.addCarro);
            this.panel2.Controls.Add(this.textBoxPesoIn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxTLong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxPortata);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxTarga);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 174);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxProdotto
            // 
            this.comboBoxProdotto.FormattingEnabled = true;
            this.comboBoxProdotto.Location = new System.Drawing.Point(373, 114);
            this.comboBoxProdotto.Name = "comboBoxProdotto";
            this.comboBoxProdotto.Size = new System.Drawing.Size(152, 21);
            this.comboBoxProdotto.TabIndex = 20;
            // 
            // comboBoxTreno
            // 
            this.comboBoxTreno.FormattingEnabled = true;
            this.comboBoxTreno.Location = new System.Drawing.Point(373, 73);
            this.comboBoxTreno.Name = "comboBoxTreno";
            this.comboBoxTreno.Size = new System.Drawing.Size(152, 21);
            this.comboBoxTreno.TabIndex = 19;
            // 
            // deleteInputs
            // 
            this.deleteInputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.deleteInputs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteInputs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteInputs.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteInputs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteInputs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteInputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInputs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInputs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteInputs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteInputs.Location = new System.Drawing.Point(586, 98);
            this.deleteInputs.Name = "deleteInputs";
            this.deleteInputs.Size = new System.Drawing.Size(166, 48);
            this.deleteInputs.TabIndex = 18;
            this.deleteInputs.Text = "Cancella Dati";
            this.deleteInputs.UseVisualStyleBackColor = false;
            this.deleteInputs.Click += new System.EventHandler(this.deleteInputs_Click);
            // 
            // addCarro
            // 
            this.addCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.addCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCarro.Location = new System.Drawing.Point(586, 14);
            this.addCarro.Name = "addCarro";
            this.addCarro.Size = new System.Drawing.Size(166, 48);
            this.addCarro.TabIndex = 16;
            this.addCarro.Text = "Aggiungi Carro";
            this.addCarro.UseVisualStyleBackColor = false;
            this.addCarro.Click += new System.EventHandler(this.addCarro_Click);
            // 
            // textBoxPesoIn
            // 
            this.textBoxPesoIn.Location = new System.Drawing.Point(373, 30);
            this.textBoxPesoIn.Name = "textBoxPesoIn";
            this.textBoxPesoIn.Size = new System.Drawing.Size(152, 20);
            this.textBoxPesoIn.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Peso In :";
            // 
            // textBoxTLong
            // 
            this.textBoxTLong.Location = new System.Drawing.Point(118, 74);
            this.textBoxTLong.Name = "textBoxTLong";
            this.textBoxTLong.Size = new System.Drawing.Size(152, 20);
            this.textBoxTLong.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "T_Long :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Prodotto :";
            // 
            // textBoxPortata
            // 
            this.textBoxPortata.Location = new System.Drawing.Point(118, 115);
            this.textBoxPortata.Name = "textBoxPortata";
            this.textBoxPortata.Size = new System.Drawing.Size(152, 20);
            this.textBoxPortata.TabIndex = 5;
            this.textBoxPortata.TextChanged += new System.EventHandler(this.textBoxPortata_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Portata :";
            // 
            // textBoxTarga
            // 
            this.textBoxTarga.Location = new System.Drawing.Point(118, 30);
            this.textBoxTarga.Name = "textBoxTarga";
            this.textBoxTarga.Size = new System.Drawing.Size(152, 20);
            this.textBoxTarga.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Targa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Treno :";
            // 
            // pesatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "pesatura";
            this.Size = new System.Drawing.Size(875, 565);
            this.Load += new System.EventHandler(this.pesatura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
       
    
        private System.Windows.Forms.TextBox textBoxPesoIn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTLong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPortata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
 
        private System.Windows.Forms.Button deleteInputs;
        private System.Windows.Forms.Button addCarro;
        
       
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxProdotto;
        private System.Windows.Forms.ComboBox comboBoxTreno;
    }
}
