using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookS : IPhotoBook<PhotoBookPageS>
    {
        public IList<PhotoBookPageS> Pages { get; }

        public PhotoBookS(int pagesNo)
        {
            Pages = new List<PhotoBookPageS>();
            
            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageS());
            }
        }
        
        public void AddPhotoToPhotoBook(PhotoBookPageS page)
        {
            throw new System.NotImplementedException();
        }

        public void RemovePhotoFromPhotoBook(PhotoBookPageS page)
        {
            throw new System.NotImplementedException();
        }

        public PhotoBookPageS ShowPageByPageNo(int pageNo)
        {
            throw new System.NotImplementedException();
        }
    }
}