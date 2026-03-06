using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    public class ProductData
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "laptop",
                Category = "electronics",
                Price = 899,
                Amount = 5,
            },
            new Product()
            { Id = 2,
                Name = "mouse",
                Category = "electronics",
                Price = 25,
                Amount = 50

            },
            new Product()
            {
                Id = 3,
                Name = "keyboard",
                Category = "electronics",
                Price = 45,
                Amount = 30
            },
            new Product()
            {
                Id = 4,
                Name = "monitor",
                Category = "electronics",
                Price = 120,
                Amount = 10

            },
            new Product()
            {
                Id = 5,
                Name = "desk",
                Category = "furniture",
                Price = 150,
                Amount = 3
            },
            new Product()
            {
                Id = 6,
                Name = "chair",
                Category = "furniture",
                Price = 80,
                Amount = 7

            },
            new Product()
            {
                Id = 7,
                Name = "lamp",
                Category = "home",
                Price = 20,
                Amount = 40
            },
            new Product()
            {
                Id = 8,
                Name = "phone",
                Category = "electronics",
                Price = 699,
                Amount = 8
            },
            new Product()
            {
                Id = 9,
                Name = "notebook",
                Category = "office",
                Price = 5,
                Amount = 200
            },
            new Product()
            {
                Id = 10,
                Name = "backpack",
                Category = "accessories",
                Price = 60,
                Amount = 15

            },
        };
    }   
}
