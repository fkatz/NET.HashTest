using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Entities
{
    public class User
    {
        public enum AccessPermissions
        {
            RESTRICTED = 0b0,
            CAN_LIST = 0b10,
            CAN_MODIFY = 0b100,
            CAN_SET_PERMISSIONS = 0b1000
        }
        public AccessPermissions Permissions { get; set; }

        public string Password
        {
            get
            {
                return Convert.ToBase64String(passwordHash);
            }
            set
            {
                SetPassword(value);
            }
        }

        public string Fullname
        {
            get => Name + " " + Surname;
        }
        public User(string username, string password)
        {
            Username = username;
            ResetSalt();
            passwordHash = GetHash(password);
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (AuthPassword(oldPassword))
            {
                SetPassword(newPassword);
                return true;
            }
            else return false;
        }
        public void SetPassword(string newPassword)
        {
                ResetSalt();
                passwordHash = GetHash(newPassword);
        }
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
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
            byte[] fullBytes = new byte[passBytes.Length + passwordSalt.Length];
            passBytes.CopyTo(fullBytes, 0);
            passwordSalt.CopyTo(fullBytes, passBytes.Length);
            return SHA256.Create().ComputeHash(fullBytes);
        }
        private void ResetSalt()
        {
            passwordSalt = new byte[32];
            rngCsp.GetBytes(passwordSalt);
        }
    }
}
