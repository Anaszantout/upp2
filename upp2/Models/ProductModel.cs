using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace upp2.Models
{
    public class ProductModel
    {
        [Key]
        [JsonProperty("id")]
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
        public decimal ArticleNummber { get; set; }
        public string PartitionKey { get; set; } = null!;
        public CategoryModel Category { get; set; }
    }
}

