using System.Drawing.Imaging;
using System.IO.Compression;
using System.Text.Json;

namespace ConvertNarthexPictures
{
    public class ConvertNarthexPicturesBusiness : IConvertNarthexPicturesBusiness
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
            catch (Exception)
            {
                return new byte[0];
            }
        }


        public void WriteByteArrayToFile(string filePath, byte[] data)
        {
            File.WriteAllBytes(filePath, data);
        }

        public void WriteSettings(string jsonString)
        {
            string path = @$"C:\Users\{Environment.UserName}\AppData\Roaming\ConvertNarthexSettings\";

            if (string.IsNullOrEmpty(path) || !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllText(@$"C:\Users\{Environment.UserName}\AppData\Roaming\ConvertNarthexSettings\settings.json", jsonString);
        }

        public Settings ReadSettings()
        {
            Settings settingsResult = new Settings();
            try
            {
                var settings = File.ReadAllText(@$"C:\Users\{Environment.UserName}\AppData\Roaming\ConvertNarthexSettings\settings.json");
                settingsResult = JsonSerializer.Deserialize<Settings>(settings);
                if (settingsResult != null)
                {
                    settingsResult.InputLocation = string.Empty;
                    settingsResult.OutputLocation = string.Empty;
                }
                return settingsResult;
            }
            catch (Exception)
            {
                settingsResult.InputLocation = string.Empty;
                settingsResult.OutputLocation = string.Empty;
                return settingsResult;
            }
        }

        private byte[] Compress(Stream input)
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
