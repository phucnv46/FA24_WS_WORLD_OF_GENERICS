using System.ComponentModel.DataAnnotations.Schema;

namespace World_Of_Generics_API.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public long Quantity { get; set; }

        [ForeignKey("Category")]
        public long CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
