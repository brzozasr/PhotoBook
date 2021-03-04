using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookM : IPhotoBook<PhotoBookPage>
    {
        public IList<PhotoBookPage> Pages { get; }

        public PhotoBookM(int pagesNo)
        {
            Pages = new List<PhotoBookPage>();
            
            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageM());
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