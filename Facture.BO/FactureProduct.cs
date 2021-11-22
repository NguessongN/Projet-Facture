using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BO
{
    public class FactureProduct: Product
    {
        public Product Product { get; }
        public string Total { get; set; }

        // Quantity of the factureProduct
        public double Quantity { get; set; }

        public FactureProduct()
        {
            Quantity = 0;
        }

        public FactureProduct(Product product, double quantity = 1)
        {
            Product = product;
            Price = product.Price;
            Name = product.Name;
            if (product.Quantite < quantity)
            {
                quantity = product.Quantite;
            }
            ChangeQuantity(quantity);
        }

        public FactureProduct ChangeQuantity(double quantity)
        {
            Quantity = quantity;
            Total = GetTotal() + " F";
            return this;
        }

        public double GetTotal()
        {
            return Product.Price * Quantity;
        }
    }
}
