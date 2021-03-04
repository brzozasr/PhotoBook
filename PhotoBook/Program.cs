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

            PhotoBooksController photoBooksController = new PhotoBooksController(pbS, pbM, pbL);
            
            photoBooksController.AddPhotosToBookL(190);
            photoBooksController.Display(1);
        }
    }
}