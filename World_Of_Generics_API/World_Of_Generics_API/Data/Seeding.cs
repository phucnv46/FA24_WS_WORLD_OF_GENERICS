using World_Of_Generics_API.Models;

namespace World_Of_Generics_API.Data
{
    public class Seeding
    {
        public static List<Category> Categories
        {
            get
            {
                return new List<Category>()
                {
                    new Category() {ID=1, Name="Pen",Description="Bút bi", CreateAt = DateTime.Now},
                    new Category() {ID=2, Name="T-Shirt",Description="Áo phông", CreateAt = DateTime.Now},
                };
            }
        }

        public static List<Product> Products
        {
            get
            {
                return new List<Product>()
                {
                    new Product() {ID=1, Name="Bút bi thiên long",Price=2000,CategoryID=1, CreateAt = DateTime.Now},
                    new Product() {ID=2, Name="T-Shirt",Price = 2000000,CategoryID=2 ,CreateAt = DateTime.Now},
                };
            }
        }
    }
}
