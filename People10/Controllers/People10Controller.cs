using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using People10.Models;

namespace People10.Controllers
{
    public class People10Controller : ApiController
    {
        public List<Category> GetCategoryList()
        {
            return getCategoryData();
        }

        public List<Product> GetProductList(int categoryId)
        {
            return getProductList().Where(x =>x.CategoryId==categoryId).ToList();
        }

        private List<Category> getCategoryData()
        {
            return new List<Category> { 
                new Category{
                    Description="Latest Nokia Mobiles at best prices",
                    ID=1,
                    Name="Nokia"
                },
                new Category{
                    Description="Latest Moto Mobiles at best prices",
                    ID=2,
                    Name="Motorola"
                },
                new Category{
                    Description="Latest Apple Mobiles at best prices",
                    ID=3,
                    Name="Apple"
                }
            };
        }

        private List<Product> getProductList()
        {
            return new List<Product>{
                new Product{
                    CategoryId = 1,
                    ID = 101,
                    Name = "Nokia Lumia 720",
                    Price = 25000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 1,
                    ID = 102,
                    Name = "Nokia Lumia 820",
                    Price = 50000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 1,
                    ID = 103,
                    Name = "Nokia Lumia 920",
                    Price = 22000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 1,
                    ID = 104,
                    Name = "Nokia Lumia 1020",
                    Price = 21000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 1,
                    ID = 105,
                    Name = "Nokia Lumia 1220",
                    Price = 9000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 2,
                    ID = 202,
                    Name = "Moto G",
                    Price = 12000,
                    Description="Latest Phones at cheapest price"
                },new Product{
                    CategoryId = 2,
                    ID = 203,
                    Name = "Moto G2",
                    Price = 3000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 2,
                    ID = 301,
                    Name = "Moto X",
                    Price = 9000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 2,
                    ID = 302,
                    Name = "Moto X 2",
                    Price = 12000,
                    Description="Latest Phones at cheapest price"
                },new Product{
                    CategoryId = 2,
                    ID = 303,
                    Name = "Moto Droid",
                    Price = 3000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 3,
                    ID = 202,
                    Name = "Apple 4S",
                    Price = 12000,
                    Description="Latest Phones at cheapest price"
                },new Product{
                    CategoryId = 3,
                    ID = 203,
                    Name = "Apple 5",
                    Price = 3000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 3,
                    ID = 301,
                    Name = "Apple 5S",
                    Price = 9000,
                    Description="Latest Phones at cheapest price"
                },
                new Product{
                    CategoryId = 3,
                    ID = 302,
                    Name = "Apple 6",
                    Price = 12000,
                    Description="Latest Phones at cheapest price"
                },new Product{
                    CategoryId = 3,
                    ID = 303,
                    Name = "Apple 6+",
                    Price = 3000,
                    Description="Latest Phones at cheapest price"
                }
            };
        }
    }
}