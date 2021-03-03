using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoTIFF : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type
        {
            get => Type;
            set => Type = Type == PhotoType.TIFF
                ? PhotoType.TIFF
                : throw new ApplicationException("You are trying to add the wrong photo type format (required TIFF)!");
        }

        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}