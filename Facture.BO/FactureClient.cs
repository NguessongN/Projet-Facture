using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class FactureClient
    {
        public string Nom_de_la_societe { get; set; }
        public string Nom { get; set; }
        public string Adresse_postale { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Total { get; set; }

        public List<FactureProduct> ProductsFactureList { get; set; }

        public FactureClient(string nom_de_la_societe, string nom, string adresse_postale, string telephone, string email)
        {
            Nom_de_la_societe = nom_de_la_societe;
            Nom = nom;
            Adresse_postale = adresse_postale;
            Telephone = telephone;
            Email = email;
        }

        public FactureClient()
        {
        }
    }
}
