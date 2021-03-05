using System;
using System.Collections.Generic;
using PhotoBook.Photos;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBookL : IPhotoBook<PhotoBookPage, Photo>
    {
        private static Lazy<SingletonPhotoBookL> _photoBook;
        private static readonly object Lock = new object();
        public IList<PhotoBookPage> Pages { get; }

        private SingletonPhotoBookL(int pagesNo)
        {
            Pages = new List<PhotoBookPage>();

            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageL());
            }
        }

        public static SingletonPhotoBookL GetInstance(int pagesNo)
        {
            if (_photoBook == null)
            {
                lock (Lock)
                {
                    if (_photoBook == null)
                    {
                        _photoBook = new Lazy<SingletonPhotoBookL>(() => new SingletonPhotoBookL(pagesNo));
                    }
                }
            }

            return _photoBook.Value;
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
            throw new NotImplementedException();
        }
    }
}