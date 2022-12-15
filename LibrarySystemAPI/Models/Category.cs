using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystemAPI.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryName { get; set; }
        public List<Category> CategoryList;
    }
}