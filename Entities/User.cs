using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Entities
{
    public class User
    {
        public string Password
        {
            get
            {
                return Convert.ToBase64String(passwordHash);
            }
            set
            {
                passwordHash = GetHash(value);
            }
        }

        public string Fullname
        {
            get => Name + " " + Surname;
        }
        public User(string username, string password)
        {
            Username = username;
            passwordHash = GetHash(password);
        }
        public string Username { get; set; }
        private byte[] passwordHash;
        private byte[] passwordSalt;
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool AuthPassword(string password)
        {
            return passwordHash.SequenceEqual(GetHash(password));
        }

        private byte[] GetHash(string password)
        {
            byte[] passBytes = Encoding.ASCII.GetBytes(password);
            return SHA256.Create().ComputeHash(passBytes);
        }
    }
}
