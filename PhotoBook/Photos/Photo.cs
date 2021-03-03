using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public abstract class Photo
    {
        public abstract string Name { get; set; }
        public abstract PhotoType Type { get; set; }
        public abstract PhotoSize Size { get; set; }
        public abstract DateTime CreationDate { get; set; }
    }
}