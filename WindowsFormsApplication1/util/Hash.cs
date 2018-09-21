using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.util
{
    class Hash
    {
        private string hashValue;
        private string salt;

        public Hash(string password)
        {
            generateHash(password);
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

        private string generateHash(string password)
        {
            salt = generateSalt();
            throw new NotImplementedException();
        }

        private string generateSalt()
        {
            throw new NotImplementedException();
        }
    }
}
