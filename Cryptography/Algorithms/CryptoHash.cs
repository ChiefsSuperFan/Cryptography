using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Algorithms
{
    public static class CryptoHash
    {

        //public static byte[] GetByteArray256Hash(byte[] InputValue)
        //{
        //    //byte[] stringBytes = Encoding.ASCII.GetBytes(InputValue);

        //    SHA256Managed sha = new SHA256Managed();
        //    byte[] checksum = sha.ComputeHash(InputValue);
        //    return checksum;

        //}

        public static byte[] GetSha256ByteArrayHash(byte[] InputValue)
        {
            byte[] error = new byte[0];
            try
            {
                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(InputValue);
                return checksum;
            }
            catch
            {
                return error;
            }
        }

        public static byte[] GetSha512ByteArrayHash(byte[] InputValue)
        {
            byte[] error = new byte[0];
            try
            {
                SHA512Managed sha512 = new SHA512Managed();
                byte[] checksum = sha512.ComputeHash(InputValue);
                return checksum;

            }
            catch
            {
                return error;
            }

        }
        public static string GetSHA256StringHash(string StringValue)
        {
            try
            {
                string stringValue = StringValue.Trim();
                bool check = string.IsNullOrEmpty(stringValue);
                if(check)
                {
                    return "";
                }
                
                byte[] stringBytes = Encoding.ASCII.GetBytes(stringValue);

                SHA256Managed sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(stringBytes);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
            catch
            {
                return "";
            }

        }

        public static string GetSHA512StringHash(string StringValue)
        {
            try
            {
                string stringValue = StringValue.Trim();
                bool check = string.IsNullOrEmpty(stringValue);
                if (check)
                {
                    return "";
                }
                byte[] stringBytes = Encoding.ASCII.GetBytes(stringValue);          
                SHA512Managed sha512 = new SHA512Managed();

                byte[] checksum = sha512.ComputeHash(stringBytes);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
            catch
            {
                return "";
            }
     

        }

        public static string GetSha512FileHash(string FileURL)
        {            try
            {
                bool exists = File.Exists(FileURL);
                {
                    if (exists)
                        using (FileStream stream = File.OpenRead(FileURL))
                        {
                            SHA512Managed sha512 = new SHA512Managed();
                            byte[] checksum = sha512.ComputeHash(stream);
                            return BitConverter.ToString(checksum).Replace("-", String.Empty);
                        }
                }
                return "";
            }
            catch
            {
                return "";
            }
        }
        public static string GetSha256FileHash(string FileURL)
        {
            try
            {
                bool exists = File.Exists(FileURL);
                {
                    if (exists)
                        using (FileStream stream = File.OpenRead(FileURL))
                        {
                            SHA256Managed sha = new SHA256Managed();
                            byte[] checksum = sha.ComputeHash(stream);
                            return BitConverter.ToString(checksum).Replace("-", String.Empty);
                        }
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        public static byte[] ConvertToBytes(string InputValue)
        {
            //we are often converting byte arrays to strings
            //this ACCURATELY converts them back!

            int arrayLength = InputValue.Length / 2;
            //the inputvalues will always be twice the length of the
            //byte array because when you use bit converter, each byte
            //is converted to a 2 character hex number
            byte[] convert = new byte[arrayLength];
            int index = -1;

            try
            {


                char[] inputParts = InputValue.ToCharArray();
                string hex = "";
                foreach (char part in inputParts)
                {


                    hex += part.ToString();
                    if (hex.Length == 2)
                    {
                        index++;
                        convert[index] = Convert.ToByte(hex, 16);

                        hex = "";
                    }
                }
                return convert;

            }
            catch
            {
                return convert;
            }
        }
    }
}
