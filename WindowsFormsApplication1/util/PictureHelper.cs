using System;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1.util
{
    public static class PictureHelper
    {
    	private const int WIDTH = 171;
    	private const int HEIGHT = 176;
    	
        public static Bitmap BitmapFromByteArray(byte[] picture)
        {
        	using(var memStream = new MemoryStream()){
            	memStream.Write(picture, 0, picture.Length);
            	return ResizeImage(Image.FromStream(memStream), WIDTH, HEIGHT);
        	}
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
		{
		    var destRect = new Rectangle(0, 0, width, height);
		    var destImage = new Bitmap(width, height);
		
		    destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
		
		    using (var graphics = Graphics.FromImage(destImage))
		    {
		        graphics.CompositingMode = CompositingMode.SourceCopy;
		        graphics.CompositingQuality = CompositingQuality.HighQuality;
		        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		        graphics.SmoothingMode = SmoothingMode.HighQuality;
		        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
		
		        using (var wrapMode = new ImageAttributes())
		        {
		            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
		            graphics.DrawImage(image, destRect, 0, 0, image.Width,image.Height, GraphicsUnit.Pixel, wrapMode);
		        }
		    }
		
		    return destImage;
		}
    }
}
