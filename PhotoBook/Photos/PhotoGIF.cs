using System;
using System.ComponentModel;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoGIF : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type { get; set; }
        public override PhotoSize Size { get; set; }
        public override DateTime CreationDate { get; set; }
    }
}