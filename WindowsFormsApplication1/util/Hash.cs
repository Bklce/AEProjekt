using System;

namespace WindowsFormsApplication1.util
{
    class Hash
    {
        private string hashValue;
        private string salt;

        public Hash(string password)
        {
            GenerateHash(password);
        }

        public Hash(string hashValue, string salt)
        {
            this.hashValue = hashValue;
            this.salt = salt;
        }

        public string HashValue
        { get; }

        public string Salt
        { get; }

        private string GenerateHash(string password)
        {
            salt = GenerateSalt();
            throw new NotImplementedException();
        }

        private string GenerateSalt()
        {
            throw new NotImplementedException();
        }
    }
}
