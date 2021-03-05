using System;
using System.Collections.Generic;
using PhotoBook.Photos;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBookM : IPhotoBook<PhotoBookPage, Photo>
    {
        private static Lazy<SingletonPhotoBookM> _photoBook;
        private static readonly object Lock = new object();
        public IList<PhotoBookPage> Pages { get; }

        private SingletonPhotoBookM(int pagesNo)
        {
            Pages = new List<PhotoBookPage>();

            for (int i = 0; i < pagesNo; i++)
            {
                Pages.Add(new PhotoBookPageM());
            }
        }

        public static SingletonPhotoBookM GetInstance(int pagesNo)
        {
            if (_photoBook == null)
            {
                lock (Lock)
                {
                    if (_photoBook == null)
                    {
                        _photoBook = new Lazy<SingletonPhotoBookM>(() => new SingletonPhotoBookM(pagesNo));
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