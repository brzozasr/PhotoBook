using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public interface IPhotoBook<T> where T : PhotoBookPage
    {
        public void AddPhotoToPhotoBook(T page);
        public void RemovePhotoFromPhotoBook(T page);
        public T ShowPageByPageNo(int pageNo);
    }
}