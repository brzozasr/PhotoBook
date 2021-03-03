using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoGIF : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type
        {
            get => Type;
            set => Type = Type == PhotoType.GIF
                ? PhotoType.GIF
                : throw new ApplicationException("You are trying to add the wrong photo type format (required GIF)!");
        }

        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}