using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.Lesson17.AP.Lesson1
{
    static class StreamExample
    {
        static public async Task ReadFileAsync(string path) {
            using (var streamReader = new StreamReader(path))
            {
                string line = await streamReader.ReadLineAsync();
                do
                {
                    Console.WriteLine(line);
                    line = await streamReader.ReadLineAsync();
                } while (!streamReader.EndOfStream);
            }

        }

        static public async Task WriteLinesFileAsync(string path, params string[] lines) {
            using (var streamWriter = new StreamWriter(path))
            {
                
                foreach (var line in lines)
                {
                    await streamWriter.WriteLineAsync(line);
                }
            }
        }

        static public void ArchiveFile(string inFilePath, string inFilePath2, string zipArchive) {
            using (var fileStream = File.OpenRead(inFilePath))
            using (var fileStream2 = File.OpenRead(inFilePath2))
            {
                using (var destinationFileStream = File.Create(zipArchive))
                {
                    using (var zipStream = new GZipStream(destinationFileStream, CompressionMode.Compress))
                    {
                        var singleByte = fileStream.ReadByte();
                        do
                        {
                            zipStream.WriteByte((byte)singleByte);
                            singleByte = fileStream.ReadByte();
                        } while (singleByte != -1);

                        singleByte = fileStream2.ReadByte();
                        do
                        {
                            zipStream.WriteByte((byte)singleByte);
                            singleByte = fileStream2.ReadByte();
                        } while (singleByte != -1);
                    }
                }
            }
        }
    }
}
