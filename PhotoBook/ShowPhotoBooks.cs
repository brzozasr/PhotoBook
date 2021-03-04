using System;
using System.Text;
using Microsoft.VisualBasic;
using PhotoBook.PhotoBooks;

namespace PhotoBook
{
    public class ShowPhotoBooks
    {
        private PhotoBookS _photoBookS;
        private PhotoBookM _photoBookM;
        private PhotoBookL _photoBookL;
        public ShowPhotoBooks(PhotoBookS photoBookS, PhotoBookM photoBookM,
            PhotoBookL photoBookL)
        {
            _photoBookS = photoBookS;
            _photoBookM = photoBookM;
            _photoBookL = photoBookL;
        } 
        
        public void Display(int pageNo)
        {
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
            
            int allPhotosM = 0;
            foreach (var page in _photoBookM.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotosM += countPagePhotos;
            }
            
            int allPhotosL = 0;
            foreach (var page in _photoBookL.Pages)
            {
                var countPagePhotos = page.PhotosPage.Count;
                allPhotosL += countPagePhotos;
            }

            var bookSTitle = $"Book S no photos: {allPhotosS}";
            var bookSTitleLen = bookSTitle.Length;
            var bookMTitle = $"Book M no photos: {allPhotosM}";
            var bookMTitleLen = bookMTitle.Length;
            var bookLTitle = $"Book L no photos: {allPhotosL}";
            var bookLTitleLen = bookLTitle.Length;
            
            sb.Append($"{bookSTitle}{new String(' ', 38 - bookSTitleLen)}" +
                      $"{bookMTitle}{new String(' ', 38 - bookMTitleLen)}" +
                      $"{bookLTitle}{new String(' ', 38 - bookLTitleLen)}\n");

            var noSPages = $"Page {pageNoS + 1} of {_photoBookS.Pages.Count}";
            var noSPagesLen = noSPages.Length;
            var noMPages = $"Page {pageNoM + 1} of {_photoBookM.Pages.Count}";
            var noMPagesLen = noMPages.Length;
            var noLPages = $"Page {pageNoL + 1} of {_photoBookL.Pages.Count}";
            var noLPagesLen = noLPages.Length;

            sb.Append($"{noSPages}{new String(' ', 38 - noSPagesLen)}" +
                      $"{noMPages}{new String(' ', 38 - noMPagesLen)}" +
                      $"{noLPages}{new String(' ', 38 - noLPagesLen)}\n");
                
            sb.Append($"{new String('-', 37)} {new String('-', 37)} {new String('-', 37)}\n");
        
            Console.WriteLine(sb.ToString());
        }
    }
}