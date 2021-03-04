using System.Collections.Generic;
using PhotoBook.Photos;

namespace PhotoBook.PhotoBooks
{
    public class PhotoBookM : IPhotoBook<PhotoBookPage, Photo>
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
        
        public bool AddPhotoToPhotoBook(Photo photo)
        {
            foreach (var page in Pages)
            {
                var isAdded = page.AddPhoto(photo);

                if (isAdded)
                {
                    return true;
                }
            }

            return false;
        }

        public void RemovePhotoFromPhotoBook(Photo photo)
        {
            throw new System.NotImplementedException();
        }
    }
}