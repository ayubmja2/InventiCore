using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InventiCore
{
    /// <summary>
    /// Represents a inventory system for managing products, categories, and suppliers
    /// </summary>
    internal class Inventory
    {
        // Properties
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();

        public int LowStockThreshold { get; set; } = 5; // Default threshold
        
        

        // Methods

        /// <summary>
        /// Adds a product to the inventory.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Removes a product from the inventory.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct(Product product)
        {
            var productRemove = Products.FirstOrDefault(t => t.ProductID == product.ProductID);

            if (productRemove != null)
            {
                Products.Remove(productRemove);
            }
        }
    }
}
