using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookPageS : PhotoBookPage
    {
        public override PageSize Size { get; }
        public override IList<Photo> PhotosPage { get; }

        public PhotoBookPageS()
        {
            Size = PageSize.Size15x21;
            PhotosPage = new List<Photo>();
        }
        
        public override bool AddPhoto(Photo photo)
        {
            var allPhotosSize = 0;
            foreach (var p in PhotosPage)
            {
                allPhotosSize += (int) p.Size;
            }
            
            if ((int) Size >= allPhotosSize + (int) photo.Size)
            {
                PhotosPage.Add(photo);
                return true;
            }

            return false;
        }
    }
}