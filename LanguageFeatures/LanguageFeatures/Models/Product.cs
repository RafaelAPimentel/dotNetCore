using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

        public Product(bool stock  = true)
        {
            InStock = stock;
        }

        public static Product[] GetProduct() {
            Product kayak = new Product { Name = "Kayak", Category="Water Craft", Price = 275M };
            Product lifeJacket = new Product (false){ Name = "LifeJacket", Price = 48.95M };

            kayak.Related = lifeJacket;
            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
