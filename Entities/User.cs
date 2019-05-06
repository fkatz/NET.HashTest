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
                ResetSalt();
                passwordHash = GetHash(newPassword);
                return true;
            }
            else return false;
        }
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public string Username { get; set; }
        private byte[] passwordHash;
        private string passwordSalt;
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public bool AuthPassword(string password)
        {
            return passwordHash.SequenceEqual(GetHash(password));
        }

        private byte[] GetHash(string password)
        {
            return SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(password + this.passwordSalt));
        }
        private void ResetSalt()
        {
            byte[] saltBytes = new byte[32];
            rngCsp.GetBytes(saltBytes);
            for (int i = 0; i < saltBytes.Length; i++)
            {
                double fraction = (double)saltBytes[i] / 256;
                saltBytes[i] = (byte)(fraction * 93);
                saltBytes[i] += 33;
            }
            passwordSalt = Encoding.ASCII.GetString(saltBytes);
        }
    }
}
