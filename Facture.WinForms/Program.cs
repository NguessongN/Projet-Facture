using Facture.BO;
using Facture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture.WinForms
{
    public static class Program
    {
        public static ProductRepository productRepository = new ProductRepository();
        public static List<FactureClient> facturesList = new List<FactureClient>() { };
        public static List<FactureProduct> productsList = new List<FactureProduct>() { };

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFacture());
//            Application.Run(new FormHome());
        }
    }
}
