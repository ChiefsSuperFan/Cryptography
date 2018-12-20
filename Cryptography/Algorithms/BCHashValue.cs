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

        readonly private HashAlgorithm _hashAlgorithmType;


        public BCHashValue()
        {

        }
        public BCHashValue(string InputHash, HashAlgorithm algorithm=HashAlgorithm.Sha256)
        {

            HashValue = CryptoHash.ConvertToBytes(InputHash);

            _hashAlgorithmType = algorithm;


        }
        public BCHashValue(byte[] InputHash, HashAlgorithm algorithm = HashAlgorithm.Sha256)
        {
            //source is the data to hash

            HashValue = InputHash;
        }


        public BCHashValue AddHash(BCHashValue HashObject)
        {
            BCHashValue error = new BCHashValue();
            

            try
            {
                byte[] concactH = this.HashValue.Concat(HashObject.HashValue).ToArray();




                byte[] hashConcat = CryptoHash.GetByteArray256Hash(concactH);

                switch(_hashAlgorithmType)
                {
                    case HashAlgorithm.Sha256:
                        BCHashValue addHash256 = new BCHashValue(hashConcat);
                        return addHash256;
                    case HashAlgorithm.Sha512:
                        BCHashValue addHash512 = new BCHashValue(hashConcat);
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
                List<BCHashValue> getHashes = ProcessHashObjectList(MerkleLeaves);
                if (getHashes.Count() == 1)
                {
                    byte[] bmerkelRoot = getHashes[0].HashValue;
                    string merkleRoot = BitConverter.ToString(bmerkelRoot).Replace("-", String.Empty);

                    return merkleRoot;
                }
                else
                {
                    //this should never happen!
                    return "";
                }

            }
            catch
            {
                return "";
            }
        }

        private static List<BCHashValue> ProcessHashObjectList(List<BCHashValue> HashList)
        {
            try
            {
                List<BCHashValue> hashedValues = new List<BCHashValue>();
                int index = 0;
                BCHashValue h1 = new BCHashValue();
                BCHashValue h2 = new BCHashValue();
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
                    List<BCHashValue> getNodes = ProcessHashObjectList(hashedValues);
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
