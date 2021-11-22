
namespace Facture.WinForms
{
    partial class FormHome
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
            this.listHome = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_facture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNew = new System.Windows.Forms.Button();
            this.montant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoirFact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listHome
            // 
            this.listHome.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id_facture,
            this.Nom,
            this.Date,
            this.montant});
            this.listHome.HideSelection = false;
            this.listHome.Location = new System.Drawing.Point(48, 70);
            this.listHome.Name = "listHome";
            this.listHome.Size = new System.Drawing.Size(433, 232);
            this.listHome.TabIndex = 0;
            this.listHome.UseCompatibleStateImageBehavior = false;
            this.listHome.View = System.Windows.Forms.View.Details;
            this.listHome.SelectedIndexChanged += new System.EventHandler(this.listHome_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTE DES FACTURES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Id_facture
            // 
            this.Id_facture.Text = "Numéro facture";
            this.Id_facture.Width = 100;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 117;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 96;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(520, 70);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(142, 43);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Créer nouvelle facture";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // montant
            // 
            this.montant.Text = "Montant";
            this.montant.Width = 115;
            // 
            // btnVoirFact
            // 
            this.btnVoirFact.Location = new System.Drawing.Point(520, 138);
            this.btnVoirFact.Name = "btnVoirFact";
            this.btnVoirFact.Size = new System.Drawing.Size(142, 44);
            this.btnVoirFact.TabIndex = 3;
            this.btnVoirFact.Text = "Voir facture";
            this.btnVoirFact.UseVisualStyleBackColor = true;
            this.btnVoirFact.Click += new System.EventHandler(this.btnVoirFact_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoirFact);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHome);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Id_facture;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader montant;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnVoirFact;
    }
}