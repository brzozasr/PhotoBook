using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookL : IPhotoBook<PhotoBookPageL>
    {
        public IList<PhotoBookPageL> Pages { get; }

        public PhotoBookL(int pagesNo)
        {
            Pages = new List<PhotoBookPageL>();
            
            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageL());
            }
        }

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