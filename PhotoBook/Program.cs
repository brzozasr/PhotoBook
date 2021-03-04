using System;
using PhotoBook.PhotoBooks;

namespace PhotoBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var pbS = SingletonPhotoBook.CreatePhotoBookS(30);
            var pbM = SingletonPhotoBook.CreatePhotoBookM(30);
            var pbL = SingletonPhotoBook.CreatePhotoBookL(30);

            ShowPhotoBooks photoBooks = new ShowPhotoBooks(pbS, pbM, pbL);
            
            photoBooks.Display(1);
        }
    }
}