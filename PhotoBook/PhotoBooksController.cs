using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using PhotoBook.PhotoBooks;
using PhotoBook.Photos;
using PhotoBook.Utilities;

namespace PhotoBook
{
    public class PhotoBooksController
    {
        private PhotoBookS _photoBookS;
        private PhotoBookM _photoBookM;
        private PhotoBookL _photoBookL;

        public PhotoBooksController(PhotoBookS photoBookS, PhotoBookM photoBookM,
            PhotoBookL photoBookL)
        {
            _photoBookS = photoBookS;
            _photoBookM = photoBookM;
            _photoBookL = photoBookL;
        }

        public void AddPhotosToBookS(int noOfPhotos)
        {
            var queue = GenerateQueueOfPhotos(noOfPhotos);

            int i = 0;
            var queueLen = queue.Count * 4;
            while (queue.Count >= 0 && i < queueLen)
            {
                var isAdded = false;
                if (queue.Count > 0)
                {
                    isAdded = _photoBookS.AddPhotoToPhotoBook(queue.Peek());
                }
                
                if (isAdded)
                {
                    queue.Dequeue();
                }
                // TODO
                Console.WriteLine($"i {i}, queue {queue.Count}");
                i++;
            }
            
            // TODO
            foreach (var page in _photoBookS.Pages)
            {
                Console.WriteLine($"Photos no: {page.PhotosPage.Count}");
            }
        }
        
        public void AddPhotosToBookM(int noOfPhotos)
        {
            var queue = GenerateQueueOfPhotos(noOfPhotos);

            int i = 0;
            var queueLen = queue.Count * 6;
            while (queue.Count >= 0 && i < queueLen)
            {
                var isAdded = false;
                if (queue.Count > 0)
                {
                    isAdded = _photoBookM.AddPhotoToPhotoBook(queue.Peek());
                }
                
                if (isAdded)
                {
                    queue.Dequeue();
                }
                // TODO
                Console.WriteLine($"i {i}, queue {queue.Count}");
                i++;
            }
            
            // TODO
            foreach (var page in _photoBookM.Pages)
            {
                Console.WriteLine($"Photos no: {page.PhotosPage.Count}");
            }
            
        }
        
        public void AddPhotosToBookL(int noOfPhotos)
        {
            var queue = GenerateQueueOfPhotos(noOfPhotos);

            int i = 0;
            var queueLen = queue.Count * 10;
            while (queue.Count >= 0 && i < queueLen)
            {
                var isAdded = false;
                if (queue.Count > 0)
                {
                    isAdded = _photoBookL.AddPhotoToPhotoBook(queue.Peek());
                }
                
                if (isAdded)
                {
                    queue.Dequeue();
                }
                // TODO
                Console.WriteLine($"i {i}, queue {queue.Count}");
                i++;
            }
            
            // TODO
            foreach (var page in _photoBookL.Pages)
            {
                Console.WriteLine($"Photos no: {page.PhotosPage.Count}");
            }
            
        }

        private Queue<Photo> GenerateQueueOfPhotos(int noOfPhotos)
        {
            var queue = new Queue<Photo>();

            for (int i = 0; i < noOfPhotos; i++)
            {
                queue.Enqueue(PhotoFactory.GetRandomPhoto());
            }

            return queue;
        }

        public void Display(int pageNo)
        {
            const int width = 38;

            pageNo = pageNo - 1;
            var pageNoS = pageNo < 0 ? 0 : pageNo > _photoBookS.Pages.Count - 1 ? _photoBookS.Pages.Count - 1 : pageNo;
            var pageNoM = pageNo < 0 ? 0 : pageNo > _photoBookM.Pages.Count - 1 ? _photoBookM.Pages.Count - 1 : pageNo;
            var pageNoL = pageNo < 0 ? 0 : pageNo > _photoBookL.Pages.Count - 1 ? _photoBookL.Pages.Count - 1 : pageNo;

            StringBuilder sb = new StringBuilder();

            int allPhotosS = 0;
            foreach (var page in _photoBookS.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotosS += countPagePhotos;
            }

            int photoOnPageS = _photoBookS.Pages[pageNo].PhotosPage.Count == 0 ||
                               _photoBookS.Pages[pageNo].PhotosPage == null
                ? 0
                : _photoBookS.Pages[pageNo].PhotosPage.Count;

            int allPhotosM = 0;
            foreach (var page in _photoBookM.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotosM += countPagePhotos;
            }

            int photoOnPageM = _photoBookM.Pages[pageNo].PhotosPage.Count == 0 ||
                               _photoBookM.Pages[pageNo].PhotosPage == null
                ? 0
                : _photoBookM.Pages[pageNo].PhotosPage.Count;

            int allPhotosL = 0;
            foreach (var page in _photoBookL.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotosL += countPagePhotos;
            }

            int photoOnPageL = _photoBookL.Pages[pageNo].PhotosPage.Count == 0 ||
                               _photoBookL.Pages[pageNo].PhotosPage == null
                ? 0
                : _photoBookL.Pages[pageNo].PhotosPage.Count;

            var bookSTitle = $"Book S no photos: {allPhotosS}";
            var bookSTitleLen = bookSTitle.Length;
            var bookMTitle = $"Book M no photos: {allPhotosM}";
            var bookMTitleLen = bookMTitle.Length;
            var bookLTitle = $"Book L no photos: {allPhotosL}";
            var bookLTitleLen = bookLTitle.Length;

            sb.Append($"{bookSTitle}{new String(' ', width - bookSTitleLen)}" +
                      $"{bookMTitle}{new String(' ', width - bookMTitleLen)}" +
                      $"{bookLTitle}{new String(' ', width - bookLTitleLen)}\n");

            var noSPages = $"Page {pageNoS + 1} of {_photoBookS.Pages.Count}";
            var noSPagesLen = noSPages.Length;
            var noMPages = $"Page {pageNoM + 1} of {_photoBookM.Pages.Count}";
            var noMPagesLen = noMPages.Length;
            var noLPages = $"Page {pageNoL + 1} of {_photoBookL.Pages.Count}";
            var noLPagesLen = noLPages.Length;

            sb.Append($"{noSPages}{new String(' ', width - noSPagesLen)}" +
                      $"{noMPages}{new String(' ', width - noMPagesLen)}" +
                      $"{noLPages}{new String(' ', width - noLPagesLen)}\n");

            sb.Append($"{new String('-', 37)} {new String('-', 37)} {new String('-', 37)}\n");

            int maxPhotosOnPage = Math.Max(photoOnPageS, Math.Max(photoOnPageM, photoOnPageL));

            if (photoOnPageS == 0 && photoOnPageM == 0 && photoOnPageL == 0)
            {
                var empty = "| The page is empty";
                var emptyLen = empty.Length;
                sb.AppendLine($"{empty}{new String(' ', width - emptyLen - 3)} | " +
                              $"{empty}{new String(' ', width - emptyLen - 3)} | " +
                              $"{empty}{new String(' ', width - emptyLen - 3)} |");
                sb.Append($"{new String('-', 37)} {new String('-', 37)} {new String('-', 37)}\n");
            }
            else
            {
                for (int i = 0; i < maxPhotosOnPage; i++)
                {
                    var lineBulider = "";
                    if (photoOnPageS == 0)
                    {
                        var empty = "| The page is empty";
                        var emptyLen = empty.Length;
                        lineBulider += $"{empty}{new String(' ', width - emptyLen - 3)} | ";
                    }
                    else
                    {
                    }

                    if (photoOnPageM == 0)
                    {
                        var empty = "| The page is empty";
                        var emptyLen = empty.Length;
                        lineBulider += $"{empty}{new String(' ', width - emptyLen - 3)} | ";
                    }
                    else
                    {
                    }

                    if (photoOnPageL == 0)
                    {
                        var empty = "| The page is empty";
                        var emptyLen = empty.Length;
                        lineBulider += $"{empty}{new String(' ', width - emptyLen - 3)} | ";
                    }
                    else
                    {
                    }

                    sb.AppendLine(lineBulider);
                }
            }

            Console.Write(sb.ToString());
        }
    }
}