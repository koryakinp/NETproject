using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupAssignment
{
    public class User
    {
        public User(String login, String hash, String name, String email)
        {
            this.Name = name;
            this.Username = login;
            this.Email = email;
            this.Hash = hash;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string hash;

        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        public static String curName;
        public static String curUsername;
    }
}
