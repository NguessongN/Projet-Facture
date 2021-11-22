
namespace Facture.WinForms
{
    partial class FormProduit
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.tbPrixUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Desingation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prix_unitaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(129, 228);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 34);
            this.saveBtn.TabIndex = 43;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(21, 173);
            this.tbQuantite.Multiline = true;
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.PasswordChar = '*';
            this.tbQuantite.Size = new System.Drawing.Size(183, 26);
            this.tbQuantite.TabIndex = 35;
            this.tbQuantite.TextChanged += new System.EventHandler(this.tbQuantite_TextChanged);
            // 
            // tbPrixUnit
            // 
            this.tbPrixUnit.Location = new System.Drawing.Point(21, 98);
            this.tbPrixUnit.Multiline = true;
            this.tbPrixUnit.Name = "tbPrixUnit";
            this.tbPrixUnit.PasswordChar = '*';
            this.tbPrixUnit.Size = new System.Drawing.Size(186, 27);
            this.tbPrixUnit.TabIndex = 34;
            this.tbPrixUnit.TextChanged += new System.EventHandler(this.tbPrixUnit_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Prix unitaire";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Quantité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Product List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Désignation:";
            // 
            // tbDesignation
            // 
            this.tbDesignation.Location = new System.Drawing.Point(21, 37);
            this.tbDesignation.Multiline = true;
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.PasswordChar = '*';
            this.tbDesignation.Size = new System.Drawing.Size(186, 27);
            this.tbDesignation.TabIndex = 50;
            this.tbDesignation.TextChanged += new System.EventHandler(this.tbDesignation_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Desingation,
            this.Prix_unitaire,
            this.Quantité,
            this.Total});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(245, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 225);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Desingation
            // 
            this.Desingation.Text = "Designation";
            this.Desingation.Width = 70;
            // 
            // Prix_unitaire
            // 
            this.Prix_unitaire.Text = "Prix_unitaire";
            this.Prix_unitaire.Width = 162;
            // 
            // Quantité
            // 
            this.Quantité.Text = "Quantité";
            this.Quantité.Width = 94;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 192;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(663, 277);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbDesignation);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.tbQuantite);
            this.Controls.Add(this.tbPrixUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormProduit";
            this.Text = "FormProduit";
            this.Load += new System.EventHandler(this.FormProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.TextBox tbPrixUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Desingation;
        private System.Windows.Forms.ColumnHeader Prix_unitaire;
        private System.Windows.Forms.ColumnHeader Quantité;
        private System.Windows.Forms.ColumnHeader Total;
    }
}