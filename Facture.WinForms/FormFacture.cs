using Facture.BO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Facture.WinForms
{
    public partial class FormFacture : Form
    {
        Product activeProduct = new Product();
        FactureProduct activeFactureProduct = new FactureProduct();
        double quantity = 0;

        public FormFacture()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadQuantity();
        }

        private void ReloadQuantity()
        {
            tbPrix.Text = "";
            this.comboBox2.Items.Clear();
            activeProduct = Program.productRepository.Find(x => x.Equals(this.comboBox1.SelectedItem));
            double quantity = activeProduct != null && activeProduct.Quantite > 0 ? activeProduct.Quantite : 0;
            if (quantity > 0)
            {
                tbPrix.Text = activeProduct.Price + " F";
                for (int i = 1; i <= quantity; i++)
                {
                    this.comboBox2.Items.Add(i);
                }
            }
            this.comboBox2.Refresh();
        }

        private void FormFacture_Load(object sender, EventArgs e)
        {
            ReloadProducts();
        }

        private void ReloadProducts()
        {
            if (Program.productRepository.GetAll().Count < 1)
            {
                List<Product> products = new List<Product>() {
                    new Product("Ref 1", "Canapé", 700, 18),
                    new Product("Ref 2", "Bouloir", 14200, 10),
                    new Product("Ref 3", "Chaussure", 13600, 100),
                    new Product("Ref 4", "Thé", 2800, 25),
                    new Product("Ref 5", "Rideaux", 10000, 34),
                    new Product("Ref 6", "Cahiers", 1500, 82),
                    new Product("Ref 7", "Serviettes", 3000, 40),
                };
                Program.productRepository.SaveMany(products, true);
            }
            this.comboBox1.DataSource = Program.productRepository.FindAll(x => x.Quantite > 0);
            this.comboBox1.Refresh();
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (activeProduct == null || (activeProduct != null && activeProduct.Quantite < 1))
            {
                MessageBox.Show("Selectionner un produit");
            } else if (this.comboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Selectionner une quantite");
            }
            else
            {
                if (quantity > 0)
                {
                    Program.productsList.Add(new FactureProduct(activeProduct, quantity));
                    ReloadListView();
                    ReloadForm();
                    MessageBox.Show("Ajoute avec succes");
                }
                else
                {
                    MessageBox.Show("Erreur sur la quantite");
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Hide();
            Preview previewForm = new Preview();
            previewForm.ShowDialog();
            this.Close();
        }

        private void ReloadForm()
        {
            activeFactureProduct = new FactureProduct();
            activeProduct = new Product();
            quantity = 0;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox2.SelectedText = "";
            tbPrix.Text = "";
            textBox5.Text = "";
        }

        private void FormFacture_Leave(object sender, EventArgs e)
        {
        }

        private void FormFacture_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadTotal();
        }

        private void ReloadTotal()
        {
            textBox5.Text = "";
            if (activeProduct.Quantite > 0)
            {
                quantity = double.Parse(this.comboBox2.Text);
                if (quantity > 0)
                {
                    textBox5.Text = (activeProduct.Price * quantity) + " F";
                }
            }
        }

        private void ReloadListView()
        {
            this.listView1.Items.Clear();
            int productsLength = Program.productsList.Count;
            for (int i = 0; i < productsLength; i++)
            {
                if (Program.productsList[i].Quantity > 0)
                {
                    FactureProduct fp = Program.productsList[i];
                    this.listView1.Items.Add(new ListViewItem(new string[] { fp.Name, fp.Price.ToString(), fp.Quantity.ToString(), fp.Total }));
                }
            }
            this.listView1.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProduit f = new FormProduit();
            if (f.ShowDialog() == DialogResult.OK)
            {
                ReloadForm();
            }
        }
    }
}
