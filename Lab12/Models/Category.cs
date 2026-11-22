using System.Collections.Generic;

namespace Lab12.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public List<Product> Products { get; set; } = new();
    }
}
