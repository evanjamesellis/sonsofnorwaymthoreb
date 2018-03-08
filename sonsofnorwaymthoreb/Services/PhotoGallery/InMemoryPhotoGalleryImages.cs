using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using sonsofnorwaymthoreb.Models.PhotoGallery;

namespace sonsofnorwaymthoreb.Services.PhotoGallery
{
    public class InMemoryPhotoGalleryImages : IPhotoGalleryImageData
    {
        public List<PhotoGalleryImage> _photoGalleryImages;

        public InMemoryPhotoGalleryImages()
        {
            _photoGalleryImages = new List<PhotoGalleryImage>();
            string[] imagesFileNames = Directory.GetFiles(@"wwwroot/images/photo-gallery/");

            int i = 0;
            foreach (var fileName in imagesFileNames)
            {
                _photoGalleryImages.Add(
                    new PhotoGalleryImage
                    {
                        Id = i,
                        FileName = fileName.Replace("wwwroot/", "")
                    });
                i++;
            }
        }

        public IEnumerable<PhotoGalleryImage> GetAll()
        {
            return _photoGalleryImages.OrderBy(i => i.Id);
        }

        public PhotoGalleryImage Get(int id)
        {
            return _photoGalleryImages.FirstOrDefault(i => i.Id == id);
        }

        public PhotoGalleryImage Add(PhotoGalleryImage photoGalleryImage)
        {
            photoGalleryImage.Id = _photoGalleryImages.Max(i => i.Id) + 1;
            _photoGalleryImages.Add(photoGalleryImage);

            return photoGalleryImage;
        }

        public PhotoGalleryImage Update(PhotoGalleryImage photoGalleryImage)
        {
            throw new NotImplementedException();
        }
    }
}
