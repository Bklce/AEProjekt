using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.data
{
    class User
    {
        private int id;
        private string username;
        private Hash hash;

        public User(int id, string username, Hash hash)
        {
            this.id = id;
            this.username = username;
            this.hash = hash;
        }

        public User(int id, string username): this(id, username, null)
        {}

        public int Id
        { get; }

        public string Username
        { get; set; }

        public Hash Hash
        { get; }
    }
}
