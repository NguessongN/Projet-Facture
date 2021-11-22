

namespace Facture.WinForms
{
   public class UserProlist
    {

     
        public string Name { get; }
        public double Price { get; }
        public string Total { get; set; }
        public double Quantity { get; set; }
     
        public UserProlist(string Name, double Price, string Total, double quantity = 1)
        {
            this.Name = Name;
            this.Price = Price;
            this.Total = Total;
            this.Quantity = quantity;
           
           
            
            
            /* if (product.Quantite < quantity)
            {
                quantity = product.Quantite;
            }
            ChangeQuantity(quantity);*/
        }

        /*public UserProlist ChangeQuantity(double quantity)
        {
            Quantity = quantity;
            Total = GetTotal() + " F";
            return this;
        }

        public double GetTotal()
        {
            return Product.Prix * Quantity;
        }*/
    }
}
