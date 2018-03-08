using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.PhotoGallery;

namespace sonsofnorwaymthoreb.ViewModels.PhotoGallery
{
    public class PhotoGalleryViewModel
    {
        public IEnumerable<PhotoGalleryImage> PhotoGalleryImages { get; set; }
    }
}