﻿using WindowsFormsApplication1.util;

namespace WindowsFormsApplication1.data
{
    class User
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
        { get; }

        public string Username
        { get; set; }

        public Hash Hash
        { get; }
    }
}
