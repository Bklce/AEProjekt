using System;
using System.Drawing;
using System.IO;

namespace WindowsFormsApplication1.util
{
    class PictureHelper
    {
        public static Bitmap BitmapFromByteArray(byte[] picture)
        {
            MemoryStream mStream = new MemoryStream();

            mStream.Write(picture, 0, picture.Length);
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }

        public static byte[] resizePicture(byte[] picture)
        {
            throw new NotImplementedException();
        }
    }
}
