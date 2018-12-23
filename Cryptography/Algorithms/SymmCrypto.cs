using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Cryptography.Algorithms
{
    public static class SymmCrypto
    {

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DERIVATION_ITERATIONS = 1000;

        // This constant is used to determine the keysize of the encryption algorithm in bits.
        // We divide this by 8 within the code below to get the equivalent number of bytes.
        private const int KEY_SIZE = 256;
        private const int BLOCK_SIZE=256;


        public static string Encrypt(string PlainText, string PrivateKey)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = GenerateRandomSalt();
            var ivStringBytes = GenerateRandomSalt();
            var plainTextBytes = Encoding.UTF8.GetBytes(PlainText);
            using (var password = new Rfc2898DeriveBytes(PrivateKey, saltStringBytes, DERIVATION_ITERATIONS))
            {
                var keyBytes = password.GetBytes(KEY_SIZE / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = BLOCK_SIZE;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();

                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string EncryptedText, string PrivateKey)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(EncryptedText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(KEY_SIZE / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(KEY_SIZE / 8).Take(KEY_SIZE / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((KEY_SIZE / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((KEY_SIZE / 8) * 2)).ToArray();

            try
            {
                using (var password = new Rfc2898DeriveBytes(PrivateKey, saltStringBytes, DERIVATION_ITERATIONS))
                {
                    var keyBytes = password.GetBytes(KEY_SIZE / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = BLOCK_SIZE;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    var plainTextBytes = new byte[cipherTextBytes.Length];
                                    var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                return "";
            }

        }


        public static bool EncryptFile(string SourceFileURL, string OutFileURL, string RandomKey)
        {
            //generate random salt
            byte[] salt = GenerateRandomSalt();
            string encryptedFile = OutFileURL;

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(RandomKey);
            if(!File.Exists(SourceFileURL))
            {
                return false;
            }

            //Set Rijndael symmetric encryption algorithm
            using (RijndaelManaged AES = new RijndaelManaged())
            {

                AES.KeySize = KEY_SIZE;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;

                //technically, we do not use the randomly generated password for the encryption key
                //Rfc2898DeriveBytes is an implementation of PBKDF or Password-Based Key Derivation Function 2
                //this has a slight impact on the system encryption code, but a significant impact on 
                //someone trying a brute force attack!  This function provides the actual "key" used to encrypt the file
                //it is never recommend to use the randomly generate key as the actual encryption key.  

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, DERIVATION_ITERATIONS);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                //Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption

                AES.Mode = CipherMode.CFB;
                using (FileStream fsCrypt = new FileStream(encryptedFile, FileMode.Create))
                {
                    //write salt to the begining of the output file, so in this case can be random every time
                    fsCrypt.Write(salt, 0, salt.Length);
                    using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(SourceFileURL, FileMode.Open))
                        {
                            byte[] buffer = new byte[1048576];
                            int read;
                            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                //Application.DoEvents(); 
                                cs.Write(buffer, 0, read);
                            }

                            //close up
                            fsIn.Close();
                            return true;
                        }
                    }

                }
            }


        }

        public static bool DecryptFile(string SourceFileURL, string OurFileURL, string RandomKey)
        {

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(RandomKey);
            byte[] salt = new byte[32];

            if (!File.Exists(SourceFileURL)) { return false; }

            string decryptedFile = OurFileURL;
            try
            {
                using (FileStream fsCrypt = new FileStream(SourceFileURL, FileMode.Open))
                {
                    fsCrypt.Read(salt, 0, salt.Length);
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = KEY_SIZE;
                        AES.BlockSize = 128;
                        var key = new Rfc2898DeriveBytes(passwordBytes, salt, DERIVATION_ITERATIONS);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);
                        AES.Padding = PaddingMode.PKCS7;
                        AES.Mode = CipherMode.CFB;
                        using (CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOut = new FileStream(decryptedFile, FileMode.Create))
                            {

                                int read;
                                byte[] buffer = new byte[1048576];
                                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                                {

                                    fsOut.Write(buffer, 0, read);
                                }

                                fsOut.Close();
                                cs.Close();

                                return true;


                            }

                        }

                    }


                }


            }
            catch
            {
                return false;
            }

        }


        private static byte[] GenerateRandomSalt()
        {

            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
