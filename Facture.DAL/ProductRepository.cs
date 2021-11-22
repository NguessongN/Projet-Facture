using Facture.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facture.DAL
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository()
        {
        }

        public List<Product> FindByName(string value)
        {
            return FindAll(x => x.Name.ToLower().Contains(value.ToLower()));
        }
    }
}
