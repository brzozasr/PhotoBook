using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public abstract class PhotoBookPage
    {
        public abstract PageSize Size { get; }
        public abstract IList<Photo> PagePhotos { get; }
        
        public abstract void AddPhoto(Photo photo);
        public abstract void RemovePhoto(Photo photo);
        public abstract Photo ShowPhotoByName(string name);
    }
}