using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookPageL : PhotoBookPage
    {
        public override PageSize Size { get; }
        public override IList<Photo> PhotosPage { get; }

        public PhotoBookPageL()
        {
            Size = PageSize.Size30x42;
            PhotosPage = new List<Photo>();
        }
        
        public override void AddPhoto(Photo photo)
        {
            throw new System.NotImplementedException();
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