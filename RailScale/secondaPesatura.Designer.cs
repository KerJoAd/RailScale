
using System.ComponentModel;

namespace RailScale
{
    partial class secondaPesatura
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
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxIdTreno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIdCarro = new System.Windows.Forms.ComboBox();
            this.cancCarro = new System.Windows.Forms.Button();
            this.editCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 338);
            this.panel1.TabIndex = 18;
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
            this.dataGridView2.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Treni In Partenza :";
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
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lista dei Carri :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBoxIdTreno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxIdCarro);
            this.panel2.Controls.Add(this.cancCarro);
            this.panel2.Controls.Add(this.editCarro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxPeso);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 373);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 174);
            this.panel2.TabIndex = 19;
            // 
            // comboBoxIdTreno
            // 
            this.comboBoxIdTreno.FormattingEnabled = true;
            this.comboBoxIdTreno.Location = new System.Drawing.Point(209, 72);
            this.comboBoxIdTreno.Name = "comboBoxIdTreno";
            this.comboBoxIdTreno.Size = new System.Drawing.Size(152, 21);
            this.comboBoxIdTreno.TabIndex = 25;
            this.comboBoxIdTreno.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "Treno Out :";
            // 
            // comboBoxIdCarro
            // 
            this.comboBoxIdCarro.FormattingEnabled = true;
            this.comboBoxIdCarro.Location = new System.Drawing.Point(209, 32);
            this.comboBoxIdCarro.Name = "comboBoxIdCarro";
            this.comboBoxIdCarro.Size = new System.Drawing.Size(152, 21);
            this.comboBoxIdCarro.TabIndex = 23;
            // 
            // cancCarro
            // 
            this.cancCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.cancCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancCarro.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "cancDati", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cancCarro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.cancCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.cancCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.cancCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancCarro.Location = new System.Drawing.Point(476, 98);
            this.cancCarro.Name = global::RailScale.Properties.Settings.Default.cancDati;
            this.cancCarro.Size = new System.Drawing.Size(166, 48);
            this.cancCarro.TabIndex = 22;
            this.cancCarro.Text = "Cancella Carro";
            this.cancCarro.UseVisualStyleBackColor = false;
            this.cancCarro.Click += new System.EventHandler(this.cancCarro_Click);
            // 
            // editCarro
            // 
            this.editCarro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.editCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCarro.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::RailScale.Properties.Settings.Default, "editCarro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editCarro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.editCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.editCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.editCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCarro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCarro.Location = new System.Drawing.Point(476, 21);
            this.editCarro.Name = global::RailScale.Properties.Settings.Default.editCarro;
            this.editCarro.Size = new System.Drawing.Size(166, 48);
            this.editCarro.TabIndex = 21;
            this.editCarro.Text = "Aggiorna Carro";
            this.editCarro.UseVisualStyleBackColor = false;
            this.editCarro.Click += new System.EventHandler(this.editCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID carro :";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(209, 116);
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(152, 20);
            this.textBoxPeso.TabIndex = 17;
            this.textBoxPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Peso out :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // secondaPesatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "secondaPesatura";
            this.Size = new System.Drawing.Size(875, 565);
            this.Load += new System.EventHandler(this.secondaPesatura_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancCarro;
        private System.Windows.Forms.BindingSource carroBindingSource1;
        //private FerroviaDataSetTableAdapters.carroTableAdapter carroTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxIdCarro;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxIdTreno;
        private System.Windows.Forms.Label label4;
    }
}
