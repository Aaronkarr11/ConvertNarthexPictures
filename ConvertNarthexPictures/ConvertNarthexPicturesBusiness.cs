using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Runtime.Intrinsics.X86;

namespace ConvertNarthexPictures
{
    public class ConvertNarthexPicturesBusiness
    {
        public ConvertNarthexPicturesBusiness()
        {

        }

        public byte[] ConvertPngToJpeg(byte[] pngBytes)
        {
            try
            {

                using (var ms = new MemoryStream(pngBytes))
                {
                    using (var bmp = new Bitmap(ms))
                    {
                        ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                        System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        using (var outStream = new MemoryStream())
                        {

                            var myEncoderParameter = new EncoderParameter(myEncoder, 30L);
                            myEncoderParameters.Param[0] = myEncoderParameter;
                            bmp.Save(outStream, jpgEncoder, myEncoderParameters);
                            return outStream.ToArray();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        public void WriteByteArrayToFile(string filePath, byte[] data)
        {
            File.WriteAllBytes(filePath, data);
        }


        private static byte[] Compress(Stream input)
        {
            using (var compressStream = new MemoryStream())
            using (var compressor = new DeflateStream(compressStream, CompressionMode.Compress))
            {
                input.CopyTo(compressor);
                compressor.Close();
                return compressStream.ToArray();
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

    }
}
