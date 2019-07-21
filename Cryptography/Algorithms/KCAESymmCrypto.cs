using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Cryptography.Algorithms
{
    public static class KCAESymmCrypto
    {
        private const string CONCAT = "|";

        public static string EncryptFile(string inputFile, string outputFile)
        {
            //returns the a concatenated string with first part being key, second part being
            //IV.  Another method is to stored the IV in the outfile.  
            try
            {
                string keyIVOut = "";
                using (var sourceStream = File.OpenRead(inputFile))
                using (var destinationStream = File.Create(outputFile))
                using (var provider = new AesCryptoServiceProvider())
                {

                    using (var cryptoTransform = provider.CreateEncryptor())
                    {
                        byte[] iv = provider.IV;
                        byte[] key = provider.Key;

                        string ivToBase64 = Convert.ToBase64String(iv);
                        string keyToBase64 = Convert.ToBase64String(key);

                        keyIVOut = keyToBase64 + CONCAT + ivToBase64;

                        using (var cryptoStream = new CryptoStream(destinationStream, cryptoTransform, CryptoStreamMode.Write))
                        {
                            sourceStream.CopyTo(cryptoStream);
                        }

                    }

                }


                return keyIVOut;
            }catch
            {
                return "";
            }
        }

        public static bool DecryptFile(string encryptedFile, string outputFile, string keyIV)
        {
            //keyIV is the concatenated key and iv
            try
            {
                string key = keyIV.Split('|').FirstOrDefault();
                string iv = keyIV.Split('|').LastOrDefault();

                byte[] aesKey = Convert.FromBase64String(key);
                byte[] ivValue = Convert.FromBase64String(iv);
                using (var sourceStream = File.OpenRead(encryptedFile))
                using (var destinationStream = File.Create(outputFile))
                using (var provider = new AesCryptoServiceProvider())
                {
 
                    using (var cryptoTransform = provider.CreateDecryptor(aesKey, ivValue))
                    using (var cryptoStream = new CryptoStream(sourceStream, cryptoTransform, CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(destinationStream);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
          



        }
    }
}
