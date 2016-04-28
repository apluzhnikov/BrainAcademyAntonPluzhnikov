using BA.Lesson17.AP.Lesson1;
using BA.Lesson17.AP.Lesson1.lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BA.Lesson17.AP
{
    class Program
    {
        static void Main(string[] args) {

            LabWork();

            //SerrializerExampleMethod();
            //RegExExampleMethod();


            /*StreamExampleStart();
            StreamExampleStartWithWait();
            StreamExampleWrite();

            ZipTheFile();*/

            Console.ReadLine();
        }

        private static void LabWork() {
            LabWorkClass.SerrializeToJson("Anton.json");
            LabWorkClass.ArchiveFile("Anton.json", "Anton.gz");
            LabWorkClass.SendFileToLocation("Anton.gz", @"S:\C-16-01\DATA\Anton.gz");

            LabWorkClass.ReadDataFromRemoteLocation(@"S:\C-16-01\DATA\");

        }

        private static void SerrializerExampleMethod() {
            Console.WriteLine("Binary serializer");
            SerrializerExample.SerrializeToBinary();
            SerrializerExample.DeSerrializeToObj();
            Console.WriteLine("JSON serializer");
            SerrializerExample.SerrializeToJson();
            SerrializerExample.DeSerrializeToJson();
        }

        static void RegExExampleMethod() {
            RegExExample.FindStringInFile("testFile.txt", @"0[967]3\d{7}");
        }



        #region StreamExamples

        private static void ZipTheFile() {
            StreamExample.ArchiveFile("testFile.txt","testFile2.txt", "testFile2.gz");
        }

        private static void StreamExampleStart() {
            Task.Run(
                () =>
                {
                    StreamExample.ReadFileAsync("testFile.txt");

                    StreamExample.ReadFileAsync("testFile2.txt");
                }
                );

            
        }

        private static async void StreamExampleWrite() {
            await StreamExample.WriteLinesFileAsync("testFile3.txt", "line1", "line2", "line3");
        }

        private static async void StreamExampleStartWithWait() {
            await StreamExample.ReadFileAsync("testFile.txt");
            await StreamExample.ReadFileAsync("testFile2.txt");
        }

        #endregion
    }
}
