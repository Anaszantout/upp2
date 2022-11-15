using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace upp2.Models
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public decimal ArticleNummber { get; set; }
        public CategoryModel Category { get; set; }

    }
}
