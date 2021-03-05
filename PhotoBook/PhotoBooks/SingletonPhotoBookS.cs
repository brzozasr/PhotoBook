using System;
using System.Collections.Generic;
using PhotoBook.Photos;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBookS : IPhotoBook<PhotoBookPage, Photo>
    {
        private static Lazy<SingletonPhotoBookS> _photoBook;
        private static readonly object Lock = new object();
        public IList<PhotoBookPage> Pages { get; }

        private SingletonPhotoBookS(int pagesNo)
        {
            Pages = new List<PhotoBookPage>();

            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageS());
            }
        }

        public static SingletonPhotoBookS GetInstance(int pagesNo)
        {
            if (_photoBook == null)
            {
                lock (Lock)
                {
                    if (_photoBook == null)
                    {
                        _photoBook = new Lazy<SingletonPhotoBookS>(() => new SingletonPhotoBookS(pagesNo));
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