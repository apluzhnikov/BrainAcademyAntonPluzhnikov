using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson3
{
    public class Crypto
    {

        public static string SymmetricEncrypt(string plainText, SymmetricAlgorithm key) {
            using (var memoryStream = new MemoryStream())
            using (var cryptoStream = new CryptoStream(memoryStream, key.CreateEncryptor(), CryptoStreamMode.Write))
            using (var streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.WriteLine(plainText);
                streamWriter.Close();
                cryptoStream.Close();
                var buffer = memoryStream.ToArray();
                memoryStream.Close();
                var chipperText = Convert.ToBase64String(buffer);
                return chipperText;
            }
        }

        public static string SymmetricDecrypt(string chipperText, SymmetricAlgorithm key) {
            var bytesArray = Convert.FromBase64String(chipperText);
            using (var memoryStream = new MemoryStream(bytesArray))
            using (var cryptoStream = new CryptoStream(memoryStream, key.CreateDecryptor(), CryptoStreamMode.Read))
            using (var streamReader = new StreamReader(cryptoStream))
            {                
                var plainText = streamReader.ReadLine();
                streamReader.Close();                
                cryptoStream.Close();
                memoryStream.Close();
                return plainText;
            }
        }

        public static byte[] RSAEncrypt(byte[] byteToEncrypt, RSAParameters RSAInfo, bool isOAEP) {
            byte[] encryptedData;
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAInfo);
                encryptedData = rsa.Encrypt(byteToEncrypt, isOAEP);
            }
            return encryptedData;
        }

        public static byte[] RSADecrypt(byte[] byteToDecrypt, RSAParameters RSAInfo, bool isOAEP) {
            byte[] decryptedData;
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RSAInfo);
                decryptedData = rsa.Decrypt(byteToDecrypt, isOAEP);
            }
            return decryptedData;
        }


        public static string GetHash(string plainText) {
            var sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            return Convert.ToBase64String(hash);
        }


    }
}
