using System;
using PhotoBook.PhotoBooks;
using PhotoBook.Utilities;

namespace PhotoBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoBooksController = GetController();
            var dictPhotoBooks = photoBooksController.PhotoBooks;

            int page = 1;
            int book = 0;
            PhotoBookType bookType = PhotoBookType.S;

            while (true)
            {
                Console.Clear();
                photoBooksController.Display(page, book);
                
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (page >= 1 && page < dictPhotoBooks[bookType.ToString()].Pages.Count)
                    {
                        page++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (page > 1 && page <= dictPhotoBooks[bookType.ToString()].Pages.Count)
                    {
                        page--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (book >= 0 && book < dictPhotoBooks.Count - 1)
                    {
                        book++;
                        bookType = (PhotoBookType) book;
                        
                        if (page > dictPhotoBooks[bookType.ToString()].Pages.Count)
                        {
                            page = dictPhotoBooks[bookType.ToString()].Pages.Count;
                        }
                    }
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (book > 0 && book <= dictPhotoBooks.Count - 1)
                    {
                        book--;
                        bookType = (PhotoBookType) book;
                        
                        if (page > dictPhotoBooks[bookType.ToString()].Pages.Count)
                        {
                            page = dictPhotoBooks[bookType.ToString()].Pages.Count;
                        }
                    }
                }

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        private static PhotoBooksController GetController()
        {
            var pbS = SingletonPhotoBookS.GetInstance(40);
            var pbM = SingletonPhotoBookM.GetInstance(35);
            var pbL = SingletonPhotoBookL.GetInstance(30);
            
            PhotoBooksController photoBooksController = new PhotoBooksController(pbS, pbM, pbL);
            
            photoBooksController.AddPhotosToBookS(55);
            photoBooksController.AddPhotosToBookM(115);
            photoBooksController.AddPhotosToBookL(180);

            return photoBooksController;
        }
    }
}