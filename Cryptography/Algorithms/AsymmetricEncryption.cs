using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Cryptography.Algorithms
{
    public static class AsymmetricEncryption
    {
        private static bool _optimalAsymmetricEncryptionPadding = false;

        //The NIST recommends 2048-bit keys for RSA. 
        private const int KEY_SIZE = 3072;

        public static void GenerateKeys(out string publicKey, out string publicAndPrivateKey)
        {
            using (var provider = new RSACryptoServiceProvider(KEY_SIZE))
            {
                publicKey = provider.ToXmlString(false);
                publicAndPrivateKey = provider.ToXmlString(true);
            }
        }

        public static string EncryptText(string PlainText, string PublicKeyXml)
        {
            try
            {
                if (PlainText.Length > 0 && PublicKeyXml.Length > 0)
                {
                    var encrypted = Encrypt(Encoding.UTF8.GetBytes(PlainText), PublicKeyXml);
                    return Convert.ToBase64String(encrypted);
                }
                return "";
            }
            catch
            {
                return "";
            }


        }

        private static byte[] Encrypt(byte[] data, string publicKeyXml)
        {

            using (var provider = new RSACryptoServiceProvider(KEY_SIZE))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static string DecryptText(string EncryptedText, string PublicAndPrivateKeyXml)
        {

            try
            {
                if (EncryptedText.Length > 0 && PublicAndPrivateKeyXml.Length > 0)
                {
                    var decrypted = Decrypt(Convert.FromBase64String(EncryptedText), PublicAndPrivateKeyXml);
                    return Encoding.UTF8.GetString(decrypted);
                }
                return "";
            }
            catch
            {
                return "";
            }

        }

        private static byte[] Decrypt(byte[] data, string publicAndPrivateKeyXml)
        {

            using (var provider = new RSACryptoServiceProvider(KEY_SIZE))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        public static int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }

        public static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                    keySize <= 16384 &&
                    keySize % 8 == 0;
        }

    }
}
