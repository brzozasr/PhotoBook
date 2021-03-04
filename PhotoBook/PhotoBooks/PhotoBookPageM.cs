using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookPageM : PhotoBookPage
    {
        public override PageSize Size { get; }
        public override IList<Photo> PhotosPage { get; }

        public PhotoBookPageM()
        {
            Size = PageSize.Size23x31;
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

        public override void RemovePhoto(Photo photo)
        {
            throw new System.NotImplementedException();
        }

        public override Photo ShowPhotoByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}