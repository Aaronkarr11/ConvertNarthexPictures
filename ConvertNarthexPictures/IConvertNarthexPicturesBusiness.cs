namespace ConvertNarthexPictures
{
    public interface IConvertNarthexPicturesBusiness
    {
        byte[] ConvertPngToJpeg(byte[] pngBytes);
        void WriteByteArrayToFile(string filePath, byte[] data);
    }
}