using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoRAW : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type
        {
            get => Type;
            set => Type = Type == PhotoType.RAW
                ? PhotoType.RAW
                : throw new ApplicationException("You are trying to add the wrong photo type format (required RAW)!");
        }

        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}