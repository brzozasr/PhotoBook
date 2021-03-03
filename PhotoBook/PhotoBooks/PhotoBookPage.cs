using System.Collections.Generic;
using System.Text;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public abstract class PhotoBookPage
    {
        public abstract PageSize Size { get; }
        public abstract IList<Photo> PhotosPage { get; }
        
        public abstract void AddPhoto(Photo photo);
        public abstract void RemovePhoto(Photo photo);
        public abstract Photo ShowPhotoByName(string name);

        public void Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"There are {PhotosPage.Count} photos on the page");
        }
    }
}