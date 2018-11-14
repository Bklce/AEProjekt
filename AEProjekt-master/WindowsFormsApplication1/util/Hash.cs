using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Seriendatenbank.util
{
    public class Hash
    {
        private const sbyte SALT_LENGTH = 32;
        private byte[] hashValue;
        private byte[] salt;

        public Hash(string password)
        {
            GenerateHash(password);
        }

        public Hash(string password, byte[] salt)
        {
            GenerateHash(password, salt);
        }

        public Hash(byte[] hashValue, byte[] salt)
        {
            this.hashValue = hashValue;
            this.salt = salt;
        }

        public byte[] HashValue
        {
            get { return hashValue; }
        }

        public byte[] Salt
        {
            get { return salt; }
        }

        private void GenerateHash(string password)
        {
            GenerateHash(password, GenerateSalt());
        }

        private void GenerateHash(string password, byte[] salt )
        {
            this.salt = salt;
            byte[] passwordAsBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] passwordWithSaltBytes =
              new byte[passwordAsBytes.Length + salt.Length];   

            //Mergen von salt und password arrays
            Buffer.BlockCopy(passwordAsBytes, 0, passwordWithSaltBytes, 0, passwordAsBytes.Length);
            Buffer.BlockCopy(salt, 0, passwordWithSaltBytes, passwordAsBytes.Length, salt.Length);
           
            //generieren des hashs
            hashValue = new SHA256Managed().ComputeHash(passwordWithSaltBytes);
        }

        private byte[] GenerateSalt()
        {
            byte[] salt = new byte[SALT_LENGTH];
            using(var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }

        public override bool Equals(object obj)
        {
            var hash = obj as Hash;
            return hash != null && ((IStructuralEquatable)hashValue).Equals(hash.hashValue, StructuralComparisons.StructuralEqualityComparer) &&
                ((IStructuralEquatable)salt).Equals(hash.salt, StructuralComparisons.StructuralEqualityComparer);
        }

        public override int GetHashCode()
        {
            var hashCode = -379145681;
            hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(hashValue);
            hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(salt);
            return hashCode;
        }
    }
}
