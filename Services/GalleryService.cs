using System.Collections.Generic;

namespace WebApplication1swe.Services
{
    public class GalleryImage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
    }

    public class GalleryService
    {
        private readonly List<GalleryImage> _galleryImages;

        public GalleryService()
        {
            _galleryImages = GetSampleGalleryImages();
        }

        public List<GalleryImage> GetAllImages()
        {
            return _galleryImages;
        }

        public List<string> GetAllCategories()
        {
            var categories = new HashSet<string>();
            foreach (var image in _galleryImages)
            {
                categories.Add(image.Category);
            }
            return new List<string>(categories);
        }

        public List<GalleryImage> GetImagesByCategory(string category)
        {
            if (string.IsNullOrEmpty(category))
                return _galleryImages;

            var result = new List<GalleryImage>();
            foreach (var image in _galleryImages)
            {
                if (image.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(image);
                }
            }
            return result;
        }

        private List<GalleryImage> GetSampleGalleryImages()
        {
            return new List<GalleryImage>
            {
                // Cotton Apparel
                new GalleryImage
                {
                    Id = 1,
                    Title = "Cotton T-Shirt Collection",
                    Category = "Cotton Apparel",
                    ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 2,
                    Title = "Premium Cotton Fabric Detail",
                    Category = "Cotton Apparel",
                    ImageUrl = "https://images.unsplash.com/photo-1599122954975-e4da3b5b4356?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1599122954975-e4da3b5b4356?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 3,
                    Title = "Folded Cotton Garments",
                    Category = "Cotton Apparel",
                    ImageUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // T-Shirt Collections
                new GalleryImage
                {
                    Id = 4,
                    Title = "Colorful T-Shirt Range",
                    Category = "T-Shirt Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 5,
                    Title = "Plain T-Shirt Selection",
                    Category = "T-Shirt Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1505152505862-e1c2192fb4f5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1505152505862-e1c2192fb4f5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 6,
                    Title = "Premium Cotton T-Shirts",
                    Category = "T-Shirt Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1503341338985-37898b6baf30?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1503341338985-37898b6baf30?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // Men's Wear
                new GalleryImage
                {
                    Id = 7,
                    Title = "Men's Casual Wear",
                    Category = "Men's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 8,
                    Title = "Men's Polo Collection",
                    Category = "Men's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1495521821757-a1efb6729352?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1495521821757-a1efb6729352?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 9,
                    Title = "Men's Formal Shirts",
                    Category = "Men's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1596362829167-6a6e4c8c3a79?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1596362829167-6a6e4c8c3a79?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // Women's Wear
                new GalleryImage
                {
                    Id = 10,
                    Title = "Women's T-Shirt Collection",
                    Category = "Women's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1502716707956-5d505b8e6b4e?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1502716707956-5d505b8e6b4e?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 11,
                    Title = "Women's Casual Wear",
                    Category = "Women's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1506629082632-401017bb5791?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1506629082632-401017bb5791?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 12,
                    Title = "Women's Summer Collection",
                    Category = "Women's Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1509631179647-0177331693ae?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1509631179647-0177331693ae?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // Kids Wear
                new GalleryImage
                {
                    Id = 13,
                    Title = "Kids Colorful Wear",
                    Category = "Kids Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1519238263413-b37e4baf58d0?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1519238263413-b37e4baf58d0?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 14,
                    Title = "Cute Kids T-Shirts",
                    Category = "Kids Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1536882240095-0379873feb4e?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1536882240095-0379873feb4e?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 15,
                    Title = "Kids Playful Apparel",
                    Category = "Kids Wear",
                    ImageUrl = "https://images.unsplash.com/photo-1503696146481-e4635abfb374?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1503696146481-e4635abfb374?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // Fabric Collections
                new GalleryImage
                {
                    Id = 16,
                    Title = "Premium Cotton Texture",
                    Category = "Fabric Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1559827260-dc66d52bef19?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1559827260-dc66d52bef19?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 17,
                    Title = "Textile Weave Detail",
                    Category = "Fabric Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1582901694515-bc119e7409b5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1582901694515-bc119e7409b5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 18,
                    Title = "Organic Cotton Material",
                    Category = "Fabric Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1599122954975-e4da3b5b4356?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1599122954975-e4da3b5b4356?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },

                // Garment Collections
                new GalleryImage
                {
                    Id = 19,
                    Title = "Complete Garment Range",
                    Category = "Garment Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1558618666-fcd25c85cd64?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 20,
                    Title = "Wholesale Collection Display",
                    Category = "Garment Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1569810189672-b9fbb5e67098?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1569810189672-b9fbb5e67098?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                },
                new GalleryImage
                {
                    Id = 21,
                    Title = "Premium Apparel Showcase",
                    Category = "Garment Collections",
                    ImageUrl = "https://images.unsplash.com/photo-1551028719-00167b16ebc5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=800",
                    ThumbnailUrl = "https://images.unsplash.com/photo-1551028719-00167b16ebc5?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&q=80&w=300"
                }
            };
        }
    }
}
