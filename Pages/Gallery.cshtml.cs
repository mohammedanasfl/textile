using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1swe.Services;
using System.Collections.Generic;

namespace WebApplication1swe.Pages
{
    public class GalleryModel : PageModel
    {
        private readonly GalleryService _galleryService;

        public List<GalleryImage> GalleryImages { get; set; }
        public List<string> Categories { get; set; }

        public GalleryModel()
        {
            _galleryService = new GalleryService();
        }

        public void OnGet()
        {
            GalleryImages = _galleryService.GetAllImages();
            Categories = _galleryService.GetAllCategories();
        }
    }
}
