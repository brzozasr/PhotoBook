using System.Collections.Generic;

namespace PhotoBook.PhotoBooks
{
    public interface IPhotoBook<T1, in T2> 
    {
        public IList<T1> Pages { get; }
        public bool AddPhotoToPhotoBook(T2 photo);
        public void RemovePhotoFromPhotoBook(T2 photo);
    }
}