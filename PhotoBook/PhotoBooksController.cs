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
        private IPhotoBook<PhotoBookPage, Photo> _photoBookS;
        private IPhotoBook<PhotoBookPage, Photo> _photoBookM;
        private IPhotoBook<PhotoBookPage, Photo> _photoBookL;
        private Dictionary<string, IPhotoBook<PhotoBookPage, Photo>> _photoBooks;

        public PhotoBooksController(IPhotoBook<PhotoBookPage, Photo> photoBookS,
            IPhotoBook<PhotoBookPage, Photo> photoBookM, IPhotoBook<PhotoBookPage, Photo> photoBookL)
        {
            _photoBookS = photoBookS;
            _photoBookM = photoBookM;
            _photoBookL = photoBookL;

            _photoBooks = new Dictionary<string, IPhotoBook<PhotoBookPage, Photo>>()
            {
                {"S", _photoBookS},
                {"M", _photoBookM},
                {"L", _photoBookL}
            };
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

                i++;
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

                i++;
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

                i++;
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

        public void Display(int pageNo, PhotoBookType bookType)
        {
            IPhotoBook<PhotoBookPage, Photo> photoBook = null;

            switch (bookType)
            {
                case PhotoBookType.S:
                    photoBook = _photoBookS;
                    break;
                case PhotoBookType.M:
                    photoBook = _photoBookM;
                    break;
                case PhotoBookType.L:
                    photoBook = _photoBookL;
                    break;
                default:
                    throw new ArgumentException("This kind of photo book does not exists!");
            }

            const int width = 38;
            var horizontalLine = $"+{new String('-', width)}+";

            pageNo = pageNo - 1;
            pageNo = pageNo < 0 ? 0 : pageNo > photoBook.Pages.Count - 1 ? photoBook.Pages.Count - 1 : pageNo;

            StringBuilder sb = new StringBuilder();

            int allPhotos = 0;
            foreach (var page in photoBook.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotos += countPagePhotos;
            }

            int photoOnPage = photoBook.Pages[pageNo].PhotosPage.Count == 0 ||
                              photoBook.Pages[pageNo].PhotosPage == null
                ? 0
                : photoBook.Pages[pageNo].PhotosPage.Count;

            var bookTitle = $"Photo Book {bookType} no photos: {allPhotos}";
            var bookTitleLen = bookTitle.Length;

            sb.AppendLine($"{bookTitle}{new String(' ', width - bookTitleLen)}");

            var noPages = $"Page {pageNo + 1} of {photoBook.Pages.Count} (No of photos: {photoBook.Pages[pageNo].PhotosPage.Count})";
            var noSPagesLen = noPages.Length;

            sb.AppendLine($"{noPages}{new String(' ', width - noSPagesLen)}");

            sb.AppendLine($"{horizontalLine}");

            if (photoOnPage == 0)
            {
                var empty = "| The page is empty";
                var emptyLen = empty.Length;
                sb.AppendLine($"{empty}{new String(' ', width - emptyLen)} | ");
                sb.AppendLine(horizontalLine);
            }
            else
            {
                foreach (var photo in photoBook.Pages[pageNo].PhotosPage)
                {
                    var photoTitle = $"| Photo title:";
                    var photoTitleLen = photoTitle.Length;
                    sb.AppendLine($"{photoTitle}{new String(' ', width - photoTitleLen)} |");
                    
                    var photoTitleSec = $"| {photo.Name}";
                    var photoTitleSecLen = photoTitleSec.Length;
                    sb.AppendLine($"{photoTitleSec}{new String(' ', width - photoTitleSecLen)} |");
                    
                    var photoType = $"| File type: {photo.Type}";
                    var photoTypeLen = photoType.Length;
                    sb.AppendLine($"{photoType}{new String(' ', width - photoTypeLen)} |");
                    
                    var photoSize = $"| Photo size: {photo.Size}";
                    var photoSizeLen = photoSize.Length;
                    sb.AppendLine($"{photoSize}{new String(' ', width - photoSizeLen)} |");
                    
                    var photoDate = $"| Creation date: {photo.CreationDate}";
                    var photoDateLen = photoDate.Length;
                    sb.AppendLine($"{photoDate}{new String(' ', width - photoDateLen)} |");

                    sb.AppendLine(horizontalLine);
                }
            }

            Console.Write(sb.ToString());
        }
    }
}