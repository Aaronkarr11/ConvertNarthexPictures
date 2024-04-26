using ConvertNarthexPictures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder(args).Build();
IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
string directoryPath = config["AppSettings:FilePath"];

ConvertNarthexPicturesCore core = new ConvertNarthexPicturesCore();
Console.WriteLine(directoryPath);


try
{
    string[] fileNames = Directory.GetFiles(directoryPath);
    int counter = 0;

    foreach (string fileName in fileNames)
    {
        byte[] bytes = File.ReadAllBytes(fileName);
        var newFile = core.ConvertPngToJpeg(bytes);

        string newFilePath = config["AppSettings:NewFilePath"];

        counter++;
        newFilePath = $"{newFilePath}{counter}.jpeg";
        core.WriteByteArrayToFile(newFilePath, newFile);
    }

    Console.WriteLine("All Done");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}