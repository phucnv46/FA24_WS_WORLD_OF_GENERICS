using System.ComponentModel.DataAnnotations.Schema;

namespace World_Of_Generics_API.DTOs
{
    public class ProductDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;

        public double Price { get; set; }

        public long Quantity { get; set; }

        public long CategoryID { get; set; }
    }
}
