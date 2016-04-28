using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1.lab
{
    static class LabWorkClass
    {
        static public void SerrializeToJson(string path) {
            AntonsJsonSerializer antonsJsonSerializer = new AntonsJsonSerializer();
            antonsJsonSerializer.Serialize(path);
        }

        static public void ArchiveFile(string inFilePath, string zipArchive) {
            using (var fileStream = File.OpenRead(inFilePath))
            using (var destinationFileStream = File.Create(zipArchive))
            using (var zipStream = new GZipStream(destinationFileStream, CompressionMode.Compress))
            {
                var singleByte = fileStream.ReadByte();
                do
                {
                    zipStream.WriteByte((byte)singleByte);
                    singleByte = fileStream.ReadByte();
                } while (singleByte != -1);
            }
        }

        internal static void ReadDataFromRemoteLocation(string directory) {
            Console.WriteLine("Directory: ");
            foreach (var file in Directory.GetFiles(directory))
            {
                Console.WriteLine(file);
                switch (Path.GetExtension(file))
                {
                    case ".gz":
                        {
                            var file2 = UnzipFile(file);
                            AntonsJsonSerializer antonsJsonSerializer = new AntonsJsonSerializer();
                            antonsJsonSerializer.Deserialize(file2);
                            break;
                        }
                    case ".json":
                        {
                            AntonsJsonSerializer antonsJsonSerializer = new AntonsJsonSerializer();
                            antonsJsonSerializer.Deserialize(file);
                            break;
                        }
                    case ".dat":
                        {
                            AntonsBinarySerializer antonsBinarySerializer = new AntonsBinarySerializer();
                            antonsBinarySerializer.Deserialize(file);
                            break;
                        }
                    case ".xml":
                        {
                            AntonsXMLSerializer antonsXMLSerializer = new AntonsXMLSerializer();
                            antonsXMLSerializer.Deserialize(file);
                            break;
                        }
                }
            }
        }

        static private string UnzipFile(string file) {
            var fileToReturn = (Path.GetFileName(file) + ".json");
            using (var fileStream = File.OpenRead(file))
            using (var destinationFileStream = File.Create((Path.GetFileName(file) + ".json")))
            using (var zipStream = new GZipStream(destinationFileStream, CompressionMode.Decompress))
            {
                /*var singleByte = fileStream.ReadByte();

                do
                {
                    zipStream.wr((byte)singleByte);
                    singleByte = fileStream.ReadByte();
                } while (singleByte != -1);*/
                zipStream.CopyTo(destinationFileStream);

            }
            return fileToReturn;
        }

        static public void SendFileToLocation(string file, string location) {
            File.Delete(location);
            File.Copy(file, location);
        }
    }
}
