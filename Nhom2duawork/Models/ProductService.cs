using System.Collections.Generic;
using System.Linq;

namespace Nhom2duawork.Models
{
    public class ProductService
    {
        private List<Product> _products = new List<Product>();

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }

        public void UpdateProduct(Product updatedProduct)
        {
            Product existingProduct = _products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Price = updatedProduct.Price;
            }
        }

        public void DeleteProduct(int id)
        {
            Product productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }
    }
}
