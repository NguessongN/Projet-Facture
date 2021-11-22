using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.WinForms
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnVoirFact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fonctionalitée non valide!");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Hide();
            FormFacture formFacture = new FormFacture();
            formFacture.ShowDialog();
            Close();
        }
    }
}
