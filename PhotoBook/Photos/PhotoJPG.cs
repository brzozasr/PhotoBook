using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoJPG : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type
        {
            get => Type;
            set => Type = Type == PhotoType.JPG
                ? PhotoType.JPG
                : throw new ArgumentException("You are trying to add the wrong photo type format (required JPG)!");
        }

        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}