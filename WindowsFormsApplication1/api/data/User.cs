using Seriendatenbank.util;

namespace Seriendatenbank.data
{
    public class User
    {
        public User(int id, string username, Hash hash)
        {
            Id = id;
            Username = username;
            Hash = hash;
        }

        public User(int id, string username): this(id, username, null)
        {}

        public int Id
        { get; set; }

        public string Username
        { get; set; }

        public Hash Hash
        { get; set; }
    }
}
