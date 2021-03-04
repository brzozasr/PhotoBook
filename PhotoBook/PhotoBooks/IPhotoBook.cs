using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using PhotoBook.Utilities;

namespace PhotoBook.PhotoBooks
{
    public interface IPhotoBook<T> where T : PhotoBookPage
    {
        public IList<T> Pages { get; }
        public void AddPhotoToPhotoBook(T page);
        public void RemovePhotoFromPhotoBook(T page);
        public T ShowPageByPageNo(int pageNo);
    }
}