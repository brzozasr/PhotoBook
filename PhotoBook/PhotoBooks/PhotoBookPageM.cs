using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookPageM : PhotoBookPage
    {
        public override PageSize Size { get; }
        public override IList<Photo> Photos { get; }

        public PhotoBookPageM()
        {
            Size = PageSize.Size23x31;
            Photos = new List<Photo>();
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