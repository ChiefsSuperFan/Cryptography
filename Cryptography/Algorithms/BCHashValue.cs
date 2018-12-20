using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.Algorithms
{
    public class BCHashValue
    {
   

        public byte[] HashValue { get; private set; }

        //readonly private HashAlgorithm _hashAlgorithmType;

        public HashAlgorithm HashAlgorithmType { get; private set; }


        public BCHashValue(HashAlgorithm algorithm = HashAlgorithm.Sha256)
        {
            HashAlgorithmType = algorithm;
        }
        public BCHashValue(string InputHash, HashAlgorithm algorithm=HashAlgorithm.Sha256)
        {

            HashValue = CryptoHash.ConvertToBytes(InputHash);

            HashAlgorithmType = algorithm;


        }
        public BCHashValue(byte[] InputHash, HashAlgorithm algorithm = HashAlgorithm.Sha256)
        {
            //source is the data to hash

            HashValue = InputHash;
            HashAlgorithmType = algorithm;
        }


        public BCHashValue AddHash(BCHashValue HashObject)
        {
            BCHashValue error = new BCHashValue();
            

            try
            {
                byte[] concactH = this.HashValue.Concat(HashObject.HashValue).ToArray();                

                switch(HashAlgorithmType)
                {
                    case HashAlgorithm.Sha256:
                        byte[] hashConcat256 = CryptoHash.GetSha256ByteArrayHash(concactH);
                        BCHashValue addHash256 = new BCHashValue(hashConcat256, HashAlgorithmType);
                        return addHash256;
                    case HashAlgorithm.Sha512:
                        byte[] hashConcat512 = CryptoHash.GetSha512ByteArrayHash(concactH);
                        BCHashValue addHash512 = new BCHashValue(hashConcat512, HashAlgorithmType);
                        return addHash512;
                    default:
                        BCHashValue err = new BCHashValue();
                        return error;

                }

            }
            catch
            {
                return error;


            }


        }
    }

    public enum HashAlgorithm
    {
        Sha256,
        Sha512
    }

    public class MerkleRoot
    {
        public static string GetMerkleRoot(List<BCHashValue> MerkleLeaves)
        {
            try
            {
                
                if (MerkleLeaves.Count() == 1)
                {
                    byte[] bmerkelRoot = MerkleLeaves[0].HashValue;
                    string merkleRoot = BitConverter.ToString(bmerkelRoot).Replace("-", String.Empty);

                    return merkleRoot;
                }

                if(MerkleLeaves.Count()>1)
                {
                    HashAlgorithm algorithm = MerkleLeaves[0].HashAlgorithmType;

                    List<BCHashValue> getHashes = ProcessHashObjectList(MerkleLeaves, algorithm);
                    byte[] bmerkelRoot = getHashes[0].HashValue;
                    string merkleRoot = BitConverter.ToString(bmerkelRoot).Replace("-", String.Empty);

                    return merkleRoot;

                }

                return "";

            }
            catch
            {
                return "";
            }
        }

        private static List<BCHashValue> ProcessHashObjectList(List<BCHashValue> HashList, HashAlgorithm algorithm)
        {
            try
            {
                List<BCHashValue> hashedValues = new List<BCHashValue>();
                int index = 0;
                BCHashValue h1 = new BCHashValue(algorithm);
                BCHashValue h2 = new BCHashValue(algorithm);
                int listCount = HashList.Count();

                foreach (BCHashValue hValue in HashList)
                {
                    index++;
                    if (index == 1)
                    {
                        h1 = hValue;
                    }

                    if (index == 2)
                    {
                        h2 = hValue;
                        BCHashValue addedHashes = h1.AddHash(h2);
                        hashedValues.Add(addedHashes);
                        index = 0;

                        //we have a pair, so add them

                    }
                }

                //this means we had an odd number of node hashes
                if (index == 1)
                {
                    //so add the orphaned hash object
                    hashedValues.Add(h1);
                }

                if (hashedValues.Count() == 1)
                {
                    //we are at the root!
                    return hashedValues;
                }
                else
                {
                    //recurse 
                    List<BCHashValue> getNodes = ProcessHashObjectList(hashedValues, algorithm);
                    return getNodes;

                }



            }
            catch
            {
                List<BCHashValue> err = new List<BCHashValue>();
                return err;
            }
        }
    }
}
