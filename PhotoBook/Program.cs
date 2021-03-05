using System;
using PhotoBook.PhotoBooks;
using PhotoBook.Utilities;

namespace PhotoBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var pbS = SingletonPhotoBookS.GetInstance(32);
            var pbM = SingletonPhotoBookM.GetInstance(31);
            var pbL = SingletonPhotoBookL.GetInstance(30);
            
            PhotoBooksController photoBooksController = new PhotoBooksController(pbS, pbM, pbL);
            
            photoBooksController.AddPhotosToBookL(90);
            photoBooksController.Display(2, PhotoBookType.L);
        }
    }
}