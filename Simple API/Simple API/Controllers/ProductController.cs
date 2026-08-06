using Microsoft.AspNetCore.Mvc;
using Simple_API.DTOs;

namespace Simple_API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController
    {
        public static IList<Product> products = new List<Product>();
        [HttpGet]
        public Product? GetProduct(long id)
        {
            var product = products.FirstOrDefault(x => x?.Id == id, null);
            if (product == null) return null;

            return product;
        }

        public IList<Product> GetAllProducts()
        {
            return products;
        }

        [HttpPost]
        public Product SaveProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        [HttpPatch]
        public Product? UpdateProduct(Product product)
        {
            var existingProduct = products.FirstOrDefault(x => x?.Id == product.Id, null);

            if (existingProduct == null) return null;

            existingProduct.Price = product.Price;
            existingProduct.Name = product.Name;

            return existingProduct;
        }

        [HttpDelete]
        public void DeleteProduct(long id)
        {
            var product = GetProductById(id);
            if (product == null) return;

            products.Remove(product);
        }

        private Product? GetProductById(long id)
        {
            Product product = products.FirstOrDefault(x => x?.Id == id, null);
            if (product == null) return null;

            return product;
        }

    }
}
