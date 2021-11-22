using Facture.BLL;
using Facture.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.WinForms
{
    public partial class FormProduit : Form
    {
        public List<Product> products = new List<Product>() { };
        
        public FormProduit()
        {
            InitializeComponent();    
        }

        private void FormProduit_Load(object sender, EventArgs e)
        {
            products = Program.productRepository.GetAll();
          /*  Random run = new Random();
            string s = run.Next().ToString();
            if(!string.IsNullOrEmpty(tbDesignation.Text)&& !string.IsNullOrEmpty(tbPrixUnit.Text))
            {
                Product product = new Product((run.Next().ToString()), tbDesignation.Text, tbPrixUnit.Text, tbQuantite.Text);
                products.Add(products);
                foreach(var p in products)
                {
                    lvProducts listView = new lvProducts(new string[] { s, tbDesignation.Text, tbPrixUnit.Text, tbQuantite.Text });
                    listView.Tag = p;
                    lvProducts.Items.Add(listView);
                    s = string.Empty;
                    tbPrixUnit.Text = string.Empty;
                    tbDesignation.Text = string.Empty;
                    tbQuantite.Text = string.Empty;
                }
            }*/
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Program.productRepository.Add(new Product(tbDesignation.Text, tbDesignation.Text, double.Parse(tbPrixUnit.Text), double.Parse(tbQuantite.Text)));
/*            
            ProductManager productManager = new ProductManager();
            if (!double.TryParse(tbPrixUnit.Text, out _))
                throw new Exception("prix invalide!");
            var product = new Product(tbDesignation.Text, tbDesignation.Text, double.Parse(tbPrixUnit.Text));
            //productManager.Add(product);
//*/
            MessageBox.Show($"product ajouter!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPrixUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantite_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter("sandra.txt", true))
            {
                file.WriteLine(tbDesignation.Text + "|" + tbPrixUnit.Text + "|" + tbQuantite );
            }
            Random run = new Random();
            string str = run.Next().ToString();
            if(!string.IsNullOrEmpty(tbDesignation.Text) && (!string.IsNullOrEmpty(tbPrixUnit.Text)))
            {
                Product product = new Product(tbDesignation.Text, tbQuantite.Text, double.Parse(tbPrixUnit.Text));
                products.Add(product);
            }
            foreach(var p in products)
            {
                ListViewItem listView = new ListViewItem(new string[]
                {
                    tbDesignation.Text, tbQuantite.Text, tbPrixUnit.Text
                });
                listView1.Items.Add(listView);
                listView.Tag = p;
                tbDesignation.Text = string.Empty;
                tbPrixUnit.Text = string.Empty;
                tbQuantite.Text = string.Empty;
            //    tbTotal.Text = string.Empty;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
