using System;
using PhotoBook.Photos;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBook
    {
        private static readonly Lazy<SingletonPhotoBook> Books =
            new Lazy<SingletonPhotoBook>(() => new SingletonPhotoBook());

        public static SingletonPhotoBook Instance
        {
            get => Books.Value;
        }

        private SingletonPhotoBook()
        {
        }

        public static IPhotoBook<PhotoBookPage, Photo> CreatePhotoBookS(int pageNo)
        {
            return new PhotoBookS(pageNo);
        }
        
        public static IPhotoBook<PhotoBookPage, Photo> CreatePhotoBookM(int pageNo)
        {
            return new PhotoBookM(pageNo);
        }
        
        public static IPhotoBook<PhotoBookPage, Photo> CreatePhotoBookL(int pageNo)
        {
            return new PhotoBookL(pageNo);
        }
    }
}