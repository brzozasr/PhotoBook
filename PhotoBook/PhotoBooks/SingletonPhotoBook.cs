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

        public PhotoBookS CreatePhotoBookS(int pageNo)
        {
            return new PhotoBookS(pageNo);
        }
        
        public PhotoBookM CreatePhotoBookM(int pageNo)
        {
            return new PhotoBookM(pageNo);
        }
        
        public PhotoBookL CreatePhotoBookL(int pageNo)
        {
            return new PhotoBookL(pageNo);
        }
    }
}