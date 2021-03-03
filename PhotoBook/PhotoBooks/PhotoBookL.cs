using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookL : IPhotoBook<PhotoBookPageL>
    {
        public IList<PhotoBookPageL> Pages { get; }

        public void AddPhotoToPhotoBook(PhotoBookPageL page)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePhotoFromPhotoBook(PhotoBookPageL page)
        {
            throw new System.NotImplementedException();
        }

        public PhotoBookPageL ShowPageByPageNo(int pageNo)
        {
            throw new System.NotImplementedException();
        }
    }
}