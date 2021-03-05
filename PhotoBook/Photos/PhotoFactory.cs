using System;
using PhotoBook.Utilities;

namespace PhotoBook.Photos
{
    public static class PhotoFactory
    {
        public static Photo GetRandomPhoto()
        {
            int photoType = Utils.Random.Next(0, 6);
            int[] photoSize = new[] { 117, 130, 234, 300 };

            switch (photoType)
            {
                case (int) PhotoType.JPG:
                    int photoSizeJpg = Utils.Random.Next(0, 4);
                    var jpg = new PhotoJPG();
                    jpg.Name = Guid.NewGuid().ToString();
                    jpg.Type = PhotoType.JPG;
                    jpg.Size = (PhotoSize) photoSize[photoSizeJpg];
                    jpg.CreationDate = DateTime.Now;
                    return jpg;
                case (int) PhotoType.PNG:
                    int photoSizePng = Utils.Random.Next(0, 4);
                    var png = new PhotoJPG();
                    png.Name = Guid.NewGuid().ToString();
                    png.Type = PhotoType.PNG;
                    png.Size = (PhotoSize) photoSize[photoSizePng];
                    png.CreationDate = DateTime.Now;
                    return png;
                case (int) PhotoType.GIF:
                    int photoSizeGif = Utils.Random.Next(0, 4);
                    var gif = new PhotoJPG();
                    gif.Name = Guid.NewGuid().ToString();
                    gif.Type = PhotoType.GIF;
                    gif.Size = (PhotoSize) photoSize[photoSizeGif];
                    gif.CreationDate = DateTime.Now;
                    return gif;
                case (int) PhotoType.TIFF:
                    int photoSizeTiff = Utils.Random.Next(0, 4);
                    var tiff = new PhotoJPG();
                    tiff.Name = Guid.NewGuid().ToString();
                    tiff.Type = PhotoType.TIFF;
                    tiff.Size = (PhotoSize) photoSize[photoSizeTiff];
                    tiff.CreationDate = DateTime.Now;
                    return tiff;
                case (int) PhotoType.RAW:
                    int photoSizeRaw = Utils.Random.Next(0, 4);
                    var raw = new PhotoJPG();
                    raw.Name = Guid.NewGuid().ToString();
                    raw.Type = PhotoType.RAW;
                    raw.Size = (PhotoSize) photoSize[photoSizeRaw];
                    raw.CreationDate = DateTime.Now;
                    return raw;
                case (int) PhotoType.BMP:
                    int photoSizeBmp = Utils.Random.Next(0, 4);
                    var bmp = new PhotoJPG();
                    bmp.Name = Guid.NewGuid().ToString();
                    bmp.Type = PhotoType.BMP;
                    bmp.Size = (PhotoSize) photoSize[photoSizeBmp];
                    bmp.CreationDate = DateTime.Now;
                    return bmp;
                default:
                    throw new ArgumentException("This photo type does not on exists!");
            }
        }
    }
}