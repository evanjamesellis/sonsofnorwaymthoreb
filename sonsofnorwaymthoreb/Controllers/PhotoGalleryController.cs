using Microsoft.AspNetCore.Mvc;
using sonsofnorwaymthoreb.Services.PhotoGallery;
using sonsofnorwaymthoreb.ViewModels.PhotoGallery;

namespace sonsofnorwaymthoreb.Controllers
{
    public class PhotoGalleryController : Controller
    {
        private IPhotoGalleryImageData _photoGalleryImageData;

        public PhotoGalleryController(
            IPhotoGalleryImageData photoGalleryImageData)
        {
            _photoGalleryImageData = photoGalleryImageData;
        }

        public IActionResult Index()
        {
            var model = new PhotoGalleryViewModel();

            model.PhotoGalleryImages = _photoGalleryImageData.GetAll();

            return View(model);
        }
    }
}
