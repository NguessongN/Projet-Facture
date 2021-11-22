
namespace Facture.WinForms
{
    partial class FormFacture
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btNom = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix_unitaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.factureProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAjout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.factureProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des produits de la facture\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom du client:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Location = new System.Drawing.Point(12, 111);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(39, 13);
            this.Prix.TabIndex = 4;
            this.Prix.Text = "Prix_ht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantité:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total:";
            // 
            // btNom
            // 
            this.btNom.Location = new System.Drawing.Point(520, 125);
            this.btNom.Name = "btNom";
            this.btNom.Size = new System.Drawing.Size(118, 20);
            this.btNom.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(15, 243);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(520, 174);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 33);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Enregistrer";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Designation,
            this.Prix_unitaire,
            this.Quantité,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(173, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 271);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Designation
            // 
            this.Designation.Text = "Designation";
            this.Designation.Width = 83;
            // 
            // Prix_unitaire
            // 
            this.Prix_unitaire.Text = "Prix unitaire";
            this.Prix_unitaire.Width = 108;
            // 
            // Quantité
            // 
            this.Quantité.Text = "Quantité";
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produit:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.factureProductBindingSource, "Product", true));
            this.comboBox1.DataSource = this.factureProductBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Product";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // factureProductBindingSource
            // 
            this.factureProductBindingSource.DataSource = typeof(Facture.BO.FactureProduct);
            // 
            // tbPrix
            // 
            this.tbPrix.Enabled = false;
            this.tbPrix.Location = new System.Drawing.Point(12, 140);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(121, 20);
            this.tbPrix.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(20, 295);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(102, 48);
            this.btnAjout.TabIndex = 16;
            this.btnAjout.Text = "Ajouter produit";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 17;
            this.button1.Text = "Magasin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(679, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFacture";
            this.Text = "FormFacture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFacture_FormClosed);
            this.Load += new System.EventHandler(this.FormFacture_Load);
            this.Leave += new System.EventHandler(this.FormFacture_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.factureProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Prix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btNom;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Designation;
        private System.Windows.Forms.ColumnHeader Prix_unitaire;
        private System.Windows.Forms.ColumnHeader Quantité;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource factureProductBindingSource;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button button1;
    }
}