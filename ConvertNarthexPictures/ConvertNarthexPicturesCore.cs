using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNarthexPictures
{
    public class ConvertNarthexPicturesCore
    {
        public ConvertNarthexPicturesCore()
        {

        }

        public byte[] ConvertPngToJpeg(byte[] pngBytes)
        {
            try
            {
                using (var ms = new MemoryStream(pngBytes))
                {
                    // Create a new Bitmap object from the stream
                    using (var bmp = new Bitmap(ms))
                    {
                        // Create a new MemoryStream for the output bytes
                        using (var outStream = new MemoryStream())
                        {
                            // Save the bitmap as a JPEG
                            bmp.Save(outStream, ImageFormat.Jpeg);

                            // Return the output bytes
                            return outStream.ToArray();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void WriteByteArrayToFile(string filePath, byte[] data)
        {
            File.WriteAllBytes(filePath, data);
        }



    }
}
