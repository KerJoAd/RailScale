
namespace RailScale
{
    partial class treni
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.ArrivoTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PartenzaTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimeTreno = new System.Windows.Forms.DateTimePicker();
            this.TracciaTrenoCB = new System.Windows.Forms.ComboBox();
            this.deleteTrain = new System.Windows.Forms.Button();
            this.addTrain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PartenzaRBtn = new System.Windows.Forms.RadioButton();
            this.ArrivoRBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pesoProdotto = new System.Windows.Forms.Label();
            this.pesoTreno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.trenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data :";
            // 
            // ArrivoTB
            // 
            this.ArrivoTB.Location = new System.Drawing.Point(17, 191);
            this.ArrivoTB.Name = "ArrivoTB";
            this.ArrivoTB.Size = new System.Drawing.Size(232, 20);
            this.ArrivoTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Luogo d\'arrivo :";
            // 
            // PartenzaTB
            // 
            this.PartenzaTB.Location = new System.Drawing.Point(17, 139);
            this.PartenzaTB.Name = "PartenzaTB";
            this.PartenzaTB.Size = new System.Drawing.Size(232, 20);
            this.PartenzaTB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Luogo di partenza :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimeTreno);
            this.panel1.Controls.Add(this.TracciaTrenoCB);
            this.panel1.Controls.Add(this.deleteTrain);
            this.panel1.Controls.Add(this.addTrain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PartenzaRBtn);
            this.panel1.Controls.Add(this.ArrivoRBtn);
            this.panel1.Controls.Add(this.ArrivoTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PartenzaTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 511);
            this.panel1.TabIndex = 13;
            // 
            // dateTimeTreno
            // 
            this.dateTimeTreno.Location = new System.Drawing.Point(17, 242);
            this.dateTimeTreno.Name = "dateTimeTreno";
            this.dateTimeTreno.Size = new System.Drawing.Size(232, 20);
            this.dateTimeTreno.TabIndex = 15;
            // 
            // TracciaTrenoCB
            // 
            this.TracciaTrenoCB.FormattingEnabled = true;
            this.TracciaTrenoCB.Location = new System.Drawing.Point(17, 79);
            this.TracciaTrenoCB.Name = "TracciaTrenoCB";
            this.TracciaTrenoCB.Size = new System.Drawing.Size(232, 21);
            this.TracciaTrenoCB.TabIndex = 19;
            this.TracciaTrenoCB.SelectedIndexChanged += new System.EventHandler(this.TracciaTrenoCB_SelectedIndexChanged);
            this.TracciaTrenoCB.SelectionChangeCommitted += new System.EventHandler(this.TracciaTrenoCB_SelectionChangeCommitted);
            // 
            // deleteTrain
            // 
            this.deleteTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.deleteTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTrain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteTrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteTrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTrain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTrain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTrain.Location = new System.Drawing.Point(135, 312);
            this.deleteTrain.Name = "deleteTrain";
            this.deleteTrain.Size = new System.Drawing.Size(114, 41);
            this.deleteTrain.TabIndex = 18;
            this.deleteTrain.Text = "Elimina";
            this.deleteTrain.UseVisualStyleBackColor = false;
            this.deleteTrain.Click += new System.EventHandler(this.deleteTrain_Click);
            // 
            // addTrain
            // 
            this.addTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.addTrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTrain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addTrain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addTrain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTrain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTrain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTrain.Location = new System.Drawing.Point(15, 312);
            this.addTrain.Name = "addTrain";
            this.addTrain.Size = new System.Drawing.Size(114, 41);
            this.addTrain.TabIndex = 17;
            this.addTrain.Text = "Aggiungi";
            this.addTrain.UseVisualStyleBackColor = false;
            this.addTrain.Click += new System.EventHandler(this.addTrain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero di traccia :";
            // 
            // PartenzaRBtn
            // 
            this.PartenzaRBtn.AutoSize = true;
            this.PartenzaRBtn.Location = new System.Drawing.Point(75, 33);
            this.PartenzaRBtn.Name = "PartenzaRBtn";
            this.PartenzaRBtn.Size = new System.Drawing.Size(67, 17);
            this.PartenzaRBtn.TabIndex = 13;
            this.PartenzaRBtn.TabStop = true;
            this.PartenzaRBtn.Text = "Partenza";
            this.PartenzaRBtn.UseVisualStyleBackColor = true;
            this.PartenzaRBtn.CheckedChanged += new System.EventHandler(this.PartenzaRBtn_CheckedChanged);
            // 
            // ArrivoRBtn
            // 
            this.ArrivoRBtn.AutoSize = true;
            this.ArrivoRBtn.Location = new System.Drawing.Point(17, 33);
            this.ArrivoRBtn.Name = "ArrivoRBtn";
            this.ArrivoRBtn.Size = new System.Drawing.Size(52, 17);
            this.ArrivoRBtn.TabIndex = 12;
            this.ArrivoRBtn.TabStop = true;
            this.ArrivoRBtn.Text = "Arrivo";
            this.ArrivoRBtn.UseVisualStyleBackColor = true;
            this.ArrivoRBtn.CheckedChanged += new System.EventHandler(this.ArrivoRBtn_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pesoProdotto);
            this.panel2.Controls.Add(this.pesoTreno);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(327, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 511);
            this.panel2.TabIndex = 14;
            // 
            // pesoProdotto
            // 
            this.pesoProdotto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pesoProdotto.AutoSize = true;
            this.pesoProdotto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoProdotto.Location = new System.Drawing.Point(335, 435);
            this.pesoProdotto.Name = "pesoProdotto";
            this.pesoProdotto.Size = new System.Drawing.Size(48, 23);
            this.pesoProdotto.TabIndex = 19;
            this.pesoProdotto.Text = "0 Kg";
            this.pesoProdotto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pesoTreno
            // 
            this.pesoTreno.AutoSize = true;
            this.pesoTreno.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTreno.Location = new System.Drawing.Point(62, 435);
            this.pesoTreno.Name = "pesoTreno";
            this.pesoTreno.Size = new System.Drawing.Size(48, 23);
            this.pesoTreno.TabIndex = 18;
            this.pesoTreno.Text = "0 Kg";
            this.pesoTreno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Peso totale Prodotto :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Peso totale Treno :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dettagli Treno :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 196);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(490, 157);
            this.dataGridView2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(490, 116);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista dei Treni :";
            // 
            // trenoBindingSource
            // 
            this.trenoBindingSource.DataMember = "treno";
            // 
            // treni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "treni";
            this.Size = new System.Drawing.Size(875, 565);
            this.Load += new System.EventHandler(this.treni_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trenoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ArrivoTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PartenzaTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PartenzaRBtn;
        private System.Windows.Forms.RadioButton ArrivoRBtn;
        private System.Windows.Forms.Button deleteTrain;
        private System.Windows.Forms.Button addTrain;
        private System.Windows.Forms.BindingSource trenoBindingSource;
        private System.Windows.Forms.ComboBox TracciaTrenoCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimeTreno;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label pesoProdotto;
        private System.Windows.Forms.Label pesoTreno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        //     private FerroviaDataSet1 ferroviaDataSet1;
        /*    private FerroviaDataSet1TableAdapters.trenoTableAdapter trenoTableAdapter;
            private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn partenzaDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn destinazioneDataGridViewTextBoxColumn;
            private System.Windows.Forms.DataGridViewTextBoxColumn datapartenzaDataGridViewTextBoxColumn;
        */
    }
}
