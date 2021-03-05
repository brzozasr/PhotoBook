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
        
        public abstract bool AddPhoto(Photo photo);
    }
}