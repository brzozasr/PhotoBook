using System.Collections.Generic;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookPageS : PhotoBookPage
    {
        public override PageSize Size { get; }
        public override IList<Photo> Photos { get; }

        public PhotoBookPageS()
        {
            Size = PageSize.Size15x21;
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