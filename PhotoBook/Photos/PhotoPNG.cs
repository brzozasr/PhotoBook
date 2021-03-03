using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoPNG : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type
        {
            get => Type;
            set => Type = Type == PhotoType.PNG
                ? PhotoType.PNG
                : throw new ApplicationException("You are trying to add the wrong photo type format (required PNG)!");
        }

        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}