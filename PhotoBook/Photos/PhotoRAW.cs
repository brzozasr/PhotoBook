using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public class PhotoRAW : Photo
    {
        public override string Name { get; set; }

        public override PhotoType Type { get; set; }
        public override PhotoSize Size { get; set; }
        public override string CreationDate { get; set; }
    }
}