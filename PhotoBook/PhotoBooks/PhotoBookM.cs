using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookM : IPhotoBook<PhotoBookPageM>
    {
        public IList<PhotoBookPageM> Pages { get; }
        public void AddPhotoToPhotoBook(PhotoBookPageM page)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePhotoFromPhotoBook(PhotoBookPageM page)
        {
            throw new System.NotImplementedException();
        }

        public PhotoBookPageM ShowPageByPageNo(int pageNo)
        {
            throw new System.NotImplementedException();
        }
    }
}