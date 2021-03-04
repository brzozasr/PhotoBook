using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookS : IPhotoBook<PhotoBookPage>
    {
        public IList<PhotoBookPage> Pages { get; }

        public PhotoBookS(int pagesNo)
        {
            Pages = new List<PhotoBookPage>();
            
            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageS());
            }
        }
        
        public void AddPhotoToPhotoBook(PhotoBookPage page)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePhotoFromPhotoBook(PhotoBookPage page)
        {
            throw new System.NotImplementedException();
        }

        public PhotoBookPage ShowPageByPageNo(int pageNo)
        {
            throw new System.NotImplementedException();
        }
    }
}