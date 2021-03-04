using System;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBook
    {
        private static readonly Lazy<SingletonPhotoBook> BookS =
            new Lazy<SingletonPhotoBook>(() => new SingletonPhotoBook());

        public static SingletonPhotoBook Instance
        {
            get => BookS.Value;
        }

        private SingletonPhotoBook()
        {
        }

        public static PhotoBookS CreatePhotoBookS(int pageNo)
        {
            return new(30);
        }
        
        public static PhotoBookM CreatePhotoBookM(int pageNo)
        {
            return new(pageNo);
        }
        
        public static PhotoBookL CreatePhotoBookL(int pageNo)
        {
            return new(pageNo);
        }
    }
}