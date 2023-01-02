using Azure.Storage.Blobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blobstoorageConsole
{
    class Program
    {

        // Upload Files 

        static  string conn = "DefaultEndpointsProtocol=https;AccountName=rashidgtp;AccountKey=Xhhjr9jtucvSG4o9TJUj+yIROqcffRX2R6sdlIqiqKhdr72K3JWr0jAYeQnml97iAWiCP3uwh2ik+ASt5Ha0mw==;EndpointSuffix=core.windows.net";
        static string container_name = "newrashidgtpone";

      //static  string conn = "DefaultEndpointsProtocol=https;AccountName=rashidgtp;AccountKey=Xhhjr9jtucvSG4o9TJUj+yIROqcffRX2R6sdlIqiqKhdr72K3JWr0jAYeQnml97iAWiCP3uwh2ik+ASt5Ha0mw==;EndpointSuffix=core.windows.net";
      // static string container_name = "rashidgtpone";
      //  static string folderpath = @"C:\Users\rashid.mahmood\Desktop\New folder\";
        static void Main(string[] args)
        {

            // var files = Directory.GetFiles(folderpath, "*", SearchOption.AllDirectories);


            // BlobContainerClient cclinet = new BlobContainerClient(conn, container_name);


            //foreach(var file in files)
            // {
            //     var filePathOverCloud = file.Replace(folderpath, string.Empty);
            //     using (MemoryStream st = new MemoryStream(File.ReadAllBytes(file)))
            //     {
            //            cclinet.UploadBlob(filePathOverCloud, st);
            //         Console.WriteLine(filePathOverCloud+"Uploaded");
            //     }
            //     Console.Read();

            // }

            BlobServiceClient blobServiceClient = new BlobServiceClient(conn);
            BlobContainerClient blobContainerClient =blobServiceClient.CreateBlobContainer (container_name);


            var files = Directory.GetFiles(@"C:\Users\rashid.mahmood\Desktop\New folder");

            foreach(var file in files)
            { 
                using (MemoryStream stream = new MemoryStream(File.ReadAllBytes(file)))
                {
                    blobContainerClient.UploadBlob(Path.GetFileName(file), stream);
                }

                Console.WriteLine(file + "Uploaded");
            }

            Console.ReadKey();

        }
    }
}
