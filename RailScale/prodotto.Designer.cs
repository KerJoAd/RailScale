
namespace RailScale
{
    partial class prodotto
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
            this.comboBoxAddProduct = new System.Windows.Forms.ComboBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxAddProduct);
            this.panel1.Controls.Add(this.deleteProduct);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNameProduct);
            this.panel1.Location = new System.Drawing.Point(22, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 523);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxAddProduct
            // 
            this.comboBoxAddProduct.FormattingEnabled = true;
            this.comboBoxAddProduct.Location = new System.Drawing.Point(60, 137);
            this.comboBoxAddProduct.Name = "comboBoxAddProduct";
            this.comboBoxAddProduct.Size = new System.Drawing.Size(265, 21);
            this.comboBoxAddProduct.TabIndex = 24;
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.deleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteProduct.Location = new System.Drawing.Point(197, 284);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(114, 41);
            this.deleteProduct.TabIndex = 23;
            this.deleteProduct.Text = "Elimina";
            this.deleteProduct.UseVisualStyleBackColor = false;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(103)))), ((int)(((byte)(77)))));
            this.addProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(108)))), ((int)(((byte)(87)))));
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProduct.Location = new System.Drawing.Point(77, 284);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(114, 41);
            this.addProduct.TabIndex = 22;
            this.addProduct.Text = "Aggiungi";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero ONU :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Denominazione :";
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(60, 205);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(265, 20);
            this.textBoxNameProduct.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(434, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 523);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(379, 270);
            this.dataGridView1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Lista Prodotti";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // prodotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "prodotto";
            this.Size = new System.Drawing.Size(875, 565);
            this.Load += new System.EventHandler(this.prodotto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
       // private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label label4;
        private FerroviaDataSet ferroviaDataSet;
        private System.Windows.Forms.BindingSource trenoBindingSource;
        private FerroviaDataSetTableAdapters.trenoTableAdapter trenoTableAdapter;
        private System.Windows.Forms.BindingSource prodottoBindingSource;
        private System.Windows.Forms.ComboBox comboBoxAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
