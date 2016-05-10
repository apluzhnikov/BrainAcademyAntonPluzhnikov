using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18.lesson3.lab1
{
    class CryptoLab
    {
        public static bool SavePass(string toEncript) {
            byte[] byteToEncrypt = Encoding.UTF8.GetBytes(toEncript);

            try
            {
                var RSAInfo = KeysManager.RSA.ExportParameters(false);
                KeysManager.RSA.ImportParameters(RSAInfo);
                var encryptedData = KeysManager.RSA.Encrypt(byteToEncrypt, false);
                File.WriteAllLines(@"d:\passdata.txt", new string[] { Convert.ToBase64String(encryptedData) });
                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }

        public static bool CheckPass(string toCheck) {


            var RSAInfo = KeysManager.GetRsaPrivateInfo();
            KeysManager.RSA.ImportParameters(RSAInfo);
            try
            {
                using (var streamReader = new StreamReader(@"d:\passdata.txt"))
                {
                    var key = streamReader.ReadToEnd();
                    byte[] byteToDecrypt = Convert.FromBase64String(key);
                    var decryptedData = KeysManager.RSA.Decrypt(byteToDecrypt, false);
                    var filePass = Encoding.UTF8.GetString(decryptedData);
                    if (string.Equals(filePass, toCheck))
                        return true;
                    else
                        return false;
                }
            }
            catch(Exception ex)
            {

            }


            return false;
        }
    }

    public static class KeysManager
    {
        public static RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        static KeysManager() {
            ReadRsaData();
        }

        private static void ReadRsaData() {
            if (!GetRsaPubInfo())
            {
                var publicKey = RSA.ToXmlString(false);
                var privateKey = RSA.ToXmlString(true);
                File.WriteAllLines(@"d:\keyspub.xml", new string[] { publicKey });
                File.WriteAllLines(@"d:\keyspriv.xml", new string[] { privateKey });
            }
        }

        private static bool GetRsaPubInfo() {
            if (File.Exists(@"d:\keyspub.xml"))
            {
                using (var streamReader = new StreamReader(@"d:\keyspub.xml"))
                {
                    var key = streamReader.ReadToEnd();
                    RSA.FromXmlString(key);
                    return true;
                }
            }
            return false;
        }

        public static RSAParameters GetRsaPrivateInfo() {
            if (File.Exists(@"d:\keyspriv.xml"))
            {
                using (var streamReader = new StreamReader(@"d:\keyspriv.xml"))
                {
                    var key = streamReader.ReadToEnd();
                    RSA.FromXmlString(key);
                    return RSA.ExportParameters(true);
                }
            }
            return new RSAParameters();
        }
    }
}

