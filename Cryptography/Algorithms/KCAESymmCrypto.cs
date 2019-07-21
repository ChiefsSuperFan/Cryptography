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
        private const char CONCAT = '|';

        private const int ITERATION_COUNT = 1111;
        private const int KEY_SIZE = 256;
        private const int IV_LENGTH = 16;
   

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
                string key = keyIV.Split(CONCAT).FirstOrDefault();
                string iv = keyIV.Split(CONCAT).LastOrDefault();

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

        public static string DecryptText(string encryptedText, string passwordSeed)
        {
            try
            {
                byte[] aesKey = GetAESKey(passwordSeed);

                byte[] source = Convert.FromBase64String(encryptedText);
                byte[] aesIV = source.Take(IV_LENGTH).ToArray();
                byte[] cipherText = source.Skip(IV_LENGTH).ToArray();
                string plainText = "";

                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    aes.Key = aesKey;
                    aes.IV = aesIV;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    // Create the streams used for decryption.
                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {

                                // Read the decrypted bytes from the decrypting stream
                                // and place them in a string.
                                plainText = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                }
                return plainText;

            }
            catch
            {
                return "";
            }
        }

        public static string EncryptText(string inputText, string passwordSeed)
        {
            //this encrypts text and uses a password seed to create the key, instead of 
            //using the AES providor.  The IV is included in the encrypted text
            //passwordSeed is random text that would be stored somewhere in a db
            
            try
            {
                byte[] encrypted;
                byte[] aesKey = GetAESKey(passwordSeed);

                using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
                {
                    // Create a decryptor to perform the stream transform.
                    aes.Key = aesKey;
                    int ivLength = aes.IV.Length;
                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            //destinationStream.Write(provider.IV, 0, provider.IV.Length);
                            msEncrypt.Write(aes.IV, 0, aes.IV.Length);
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                //Write all data to the stream.
                                swEncrypt.Write(inputText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }

                }
                return Convert.ToBase64String(encrypted);

            }catch
            {
                return "";
            }
        }

        private static byte[] GetAESKey(string passwordSeed)
        {
            byte[] salt = { 0x0, 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6,
                    0xF1, 0xF0, 0xEE, 0x21, 0x22, 0x45 };

            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(passwordSeed, salt, ITERATION_COUNT))
            {
                byte[] key = deriveBytes.GetBytes(KEY_SIZE / 8);
                return key;
            }
        }
    }
}
