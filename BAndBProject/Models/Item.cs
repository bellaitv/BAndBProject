using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAndBProject.Models
{
    public class Item
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Price { get; set; }
        public int Type { get; set; }
    }
}