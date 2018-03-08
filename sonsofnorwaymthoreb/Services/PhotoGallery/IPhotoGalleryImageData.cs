using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.PhotoGallery;

namespace sonsofnorwaymthoreb.Services.PhotoGallery
{
    public interface IPhotoGalleryImageData
    {
        IEnumerable<PhotoGalleryImage> GetAll();
        PhotoGalleryImage Get(int id);
        PhotoGalleryImage Add(PhotoGalleryImage photoGalleryImage);
        PhotoGalleryImage Update(PhotoGalleryImage photoGalleryImage);
    }
}
