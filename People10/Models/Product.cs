using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace People10.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
    }
}