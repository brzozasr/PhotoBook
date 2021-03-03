using System;

namespace PhotoBook.PhotoBooks
{
    public sealed class SingletonPhotoBookS
    {
        private static readonly Lazy<SingletonPhotoBookS> BookS =
            new Lazy<SingletonPhotoBookS>(() => new SingletonPhotoBookS());

        public static SingletonPhotoBookS Instance
        {
            get => BookS.Value;
        }

        private SingletonPhotoBookS()
        {
        }
        
        
    }
}