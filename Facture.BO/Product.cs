using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class Product
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantite { get; set; }

        public Product()
        {
            Quantite = 0;
        }

        public Product(string reference, string name, double price, double quantite = 1)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantite = quantite;
        }

        public Product(Product product): this(product?.Reference, product?.Name,  product?.Price ?? 0)
        {

        }
        
        public Product DecrementQuantity(double quantite)
        {
            this.Quantite -= quantite;
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Reference == product.Reference;
        }

        public override int GetHashCode()
        {
            return -1865021768 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }
    }
}
