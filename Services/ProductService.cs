using System.Collections.Generic;
using System.Linq;

namespace WebApplication1swe.Services
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Fabric { get; set; }
        public List<string> AvailableSizes { get; set; }
        public List<string> AvailableColors { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = GetSampleProducts();
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public List<Product> GetProductsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
                return _products;

            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<string> GetAllCategories()
        {
            return _products.Select(p => p.Category).Distinct().ToList();
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return _products;

            var lowerSearch = searchTerm.ToLower();
            return _products.Where(p =>
                p.Name.ToLower().Contains(lowerSearch) ||
                p.Description.ToLower().Contains(lowerSearch) ||
                p.Category.ToLower().Contains(lowerSearch)
            ).ToList();
        }

        private List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Premium Men's Cotton T-Shirt",
                    Description = "High-quality 100% cotton t-shirt for men. Comfortable fit, durable fabric.",
                    Category = "Men's Cotton T-Shirts",
                    Fabric = "100% Premium Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "White", "Black", "Navy", "Gray", "Red", "Blue" },
                    ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 2,
                    Name = "Women's Cotton T-Shirt",
                    Description = "Elegant women's cotton t-shirt with a flattering fit. Perfect for wholesale.",
                    Category = "Women's Cotton T-Shirts",
                    Fabric = "100% Premium Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL" },
                    AvailableColors = new List<string> { "White", "Black", "Pink", "Purple", "Beige", "Sage Green" },
                    ImageUrl = "https://images.unsplash.com/photo-1770294759055-2fddfc606537?auto=format&fit=crop&w=400&q=80"
                },
                new Product
                {
                    Id = 3,
                    Name = "Kids' Cotton T-Shirt",
                    Description = "Soft and safe cotton t-shirt for children. Available in multiple sizes.",
                    Category = "Kids Cotton Wear",
                    Fabric = "100% Organic Cotton",
                    AvailableSizes = new List<string> { "2-4Y", "4-6Y", "6-8Y", "8-10Y", "10-12Y" },
                    AvailableColors = new List<string> { "White", "Yellow", "Light Blue", "Pink", "Green" },
                    ImageUrl = "https://images.unsplash.com/photo-1558452013-194c0f870dd2?auto=format&fit=crop&w=400&q=80"
                },
                new Product
                {
                    Id = 4,
                    Name = "Classic Polo T-Shirt",
                    Description = "Timeless polo shirt perfect for corporate and casual wear.",
                    Category = "Polo T-Shirts",
                    Fabric = "100% Cotton Pique",
                    AvailableSizes = new List<string> { "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "White", "Black", "Navy", "Red", "Khaki" },
                    ImageUrl = "https://images.unsplash.com/photo-1564722713549-91da4a8d3fe4?auto=format&fit=crop&w=400&q=80"
                },
                new Product
                {
                    Id = 5,
                    Name = "Oversized Cotton T-Shirt",
                    Description = "Trendy oversized fit perfect for modern fashion. Comfortable and stylish.",
                    Category = "Oversized T-Shirts",
                    Fabric = "100% Premium Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "White", "Black", "Cream", "Olive", "Charcoal" },
                    ImageUrl = "https://images.unsplash.com/photo-1503342217505-b0a15ec3dd18?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 6,
                    Name = "Regular Fit Cotton Shirt",
                    Description = "Versatile cotton shirt suitable for various occasions and seasons.",
                    Category = "Cotton Shirts",
                    Fabric = "100% Cotton",
                    AvailableSizes = new List<string> { "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "White", "Light Blue", "Light Pink", "Cream" },
                    ImageUrl = "https://images.unsplash.com/photo-1509305717900-84f40e786d82?auto=format&fit=crop&w=400&q=80"
                },
                new Product
                {
                    Id = 7,
                    Name = "Cotton Hoodie",
                    Description = "Comfortable and warm cotton hoodie for all seasons.",
                    Category = "Hoodies",
                    Fabric = "80% Cotton, 20% Polyester",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "Black", "Gray", "Navy", "Charcoal", "White" },
                    ImageUrl = "https://images.unsplash.com/photo-1556821552-7f41c5d440db?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 8,
                    Name = "Cotton Sweatshirt",
                    Description = "Premium cotton sweatshirt for comfort and casual style.",
                    Category = "Sweatshirts",
                    Fabric = "80% Cotton, 20% Polyester",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "Gray", "Navy", "Black", "Cream", "Maroon" },
                    ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 9,
                    Name = "Cotton Track Pants",
                    Description = "Comfortable and breathable cotton track pants for athletic and casual wear.",
                    Category = "Track Pants",
                    Fabric = "100% Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "Black", "Gray", "Navy", "Charcoal", "Maroon" },
                    ImageUrl = "https://images.unsplash.com/photo-1621376225370-2781217c204c?auto=format&fit=crop&w=400&q=80"
                },
                new Product
                {
                    Id = 10,
                    Name = "Custom Printed Apparel",
                    Description = "Customizable cotton apparel with your brand or design. Perfect for corporate gifts.",
                    Category = "Custom Printed Apparel",
                    Fabric = "100% Premium Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "Any Custom Color" },
                    ImageUrl = "https://images.unsplash.com/photo-1618885472089-43e8227c6ad7?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 11,
                    Name = "Casual Wear Collection",
                    Description = "versatile casual wear collection for everyday comfort.",
                    Category = "Casual Wear",
                    Fabric = "100% Cotton",
                    AvailableSizes = new List<string> { "XS", "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "White", "Black", "Navy", "Khaki", "Olive" },
                    ImageUrl = "https://images.unsplash.com/photo-1556439130-8a42ec494a22?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                },
                new Product
                {
                    Id = 12,
                    Name = "Premium Cotton Blend",
                    Description = "High-quality cotton blend for enhanced durability and softness.",
                    Category = "Casual Wear",
                    Fabric = "95% Cotton, 5% Elastane",
                    AvailableSizes = new List<string> { "S", "M", "L", "XL", "XXL" },
                    AvailableColors = new List<string> { "Black", "Navy", "Gray", "Heather" },
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=400"
                }
            };
        }
    }
}
