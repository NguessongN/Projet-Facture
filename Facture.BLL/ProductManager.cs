using Facture.BO;
using Facture.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.BLL
{
    public class ProductManager
    {
        private ProductRepository productRepository;

        public ProductManager()
        {
            productRepository = new ProductRepository();
        }
        public void Add(Product product)
        {
            productRepository.Add(product);
        }
        public void Delete(Product product)
        {
            productRepository.Delete(product);
        }

        public void Update(Product oldProduct, Product product)
        {
            productRepository.Set(oldProduct, product);
        }
    }
}
