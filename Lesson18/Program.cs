using Lesson18.lesson1;
using Lesson18.lesson1.lab1;
using Lesson18.lesson2;
using Lesson18.lesson2.lab1;
using Lesson18.lesson3;
using Lesson18.lesson3.lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18
{
    class Program
    {
        static void Main(string[] args) {
            Lesson1();
            Lesson2();
            Lesson3();

            Console.ReadLine();
        }

        private static void Lesson3() {
            string phrase = "lorem ipsum";
            //symmetric
            /*var key = new DESCryptoServiceProvider();
            var result = Crypto.SymmetricEncrypt(phrase, key);
            Console.WriteLine($"Result after symmetric encription: {result}");
            result = Crypto.SymmetricDecrypt(result, key);
            Console.WriteLine($"Result after symmetric decription: {result}");*/


            //asymmetric
            /*RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            var encryptBytes = Encoding.UTF8.GetBytes(phrase);           
            var publicKey = RSA.ExportParameters(false);
            var privateKey = RSA.ExportParameters(true);
            var encryptData = Crypto.RSAEncrypt(encryptBytes, publicKey, false);
            var encryptString = Encoding.UTF8.GetString(encryptData);
            var decryptedData = Crypto.RSADecrypt(encryptData, privateKey, false);
            var decryptedString = Encoding.UTF8.GetString(decryptedData);
            Console.WriteLine($"Phrase: {phrase}, after encryption {encryptString} , after decryption {decryptedString}"); */

            /*var pass = Crypto.GetHash(Console.ReadLine());
            Console.WriteLine($"encoded: {pass}");
            Console.WriteLine("Please type the pass to confirm");
            var confirmPass = Crypto.GetHash(Console.ReadLine());
            if (string.Equals(pass, confirmPass))
                Console.WriteLine("same");
            else
                Console.WriteLine("not same");*/


            //lab
            /*Console.WriteLine("Please select what to do:\nA - Save a pass\nB - Check a pass");
            switch (Console.ReadKey().Key)
            {                
                case ConsoleKey.A:
                    Console.WriteLine();
                    Console.WriteLine("Please type the pass to save");
                    if (CryptoLab.SavePass(Console.ReadLine()))
                        Console.WriteLine("saved");
                    else
                        Console.WriteLine("not saved");
                    break;
                case ConsoleKey.B:
                    Console.WriteLine();
                    Console.WriteLine("Please type the pass to check");
                    if (CryptoLab.CheckPass(Console.ReadLine()))
                        Console.WriteLine("matches");
                    else
                        Console.WriteLine("does not match");
                    break;                    
                default: break;
            }*/
            
        }

        private static void Lesson2() {
            //SecurityExample.DoSecurityWork();
            /*ZoneEvidenceExample zoneEvidenceExample = new ZoneEvidenceExample();
            zoneEvidenceExample.DoWork();*/
            //PrincipalPolicyExample.DoWork();
            //AccessControlListExample.ReadACL();
            //SandboxingExample.DoWork();
            AccessControlLisLab.ReadACL();
        }

        static void Lesson1() {
            //PointerExample.DoWork();
            //PointerExample.DoWorkWithArray();
            //PointerExample.DoWorkWithStack();
            //PointerExample.DoWorkWithPointersArray();
            //PointerExample.DoWorkWithNullableTypes();
            //PInvokeExample.DoWork();
            //StructPointerLab.DoStructWork();
        }
    }
}
