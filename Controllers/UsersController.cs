using Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Controllers
{
    public class UsersController
    {
        private readonly Dictionary<string, User> users = new Dictionary<string, User>();

        private User loggedUser;

        public enum UserValidation
        {
            VALID = 0b0,
            INVALID_EMAIL = 0b1,
            INVALID_USERNAME = 0b10,
            USERNAME_TAKEN = 0b100,
            INVALID_NAME = 0b1000,
        }

        public bool Login(string username, string password)
        {
            if (username != null && username.Length > 3 && users.ContainsKey(username))
            {
                User user = users[username];
                if (user.AuthPassword(password))
                {
                    loggedUser = user;
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public User LoggedUser()
        {
            return loggedUser;
        }

        public void Logout()
        {
            loggedUser = null;
        }

        public List<User> ListUsers()
        {
            var userQuery = users.Values.Select(user=>user);
            return userQuery.ToList();
        }
        public UserValidation AddUser(User user)
        {
            UserValidation validation = ValidateUser(user);
            if (validation == UserValidation.VALID)
            {
                users.Add(user.Username, user);
            }
            return validation;
        }
        public User GetUser(string username)
        {
            return users[username];
        }
        public bool RemoveUser(string username)
        {
            if (users.ContainsKey(username))
            {
                users.Remove(username);
                return true;
            }
            else return false;
        }
        public bool ModifyUser(User user)
        {
            if (users.ContainsKey(user.Username))
            {
                users[user.Username] = user;
                return true;
            }
            else return false;
        }
        public bool ModifyUser(string username, User user)
        {
            if (!users.ContainsKey(user.Username) && RemoveUser(username))
            {
                users[user.Username] = user;
                return true;
            }
            else return false;
        }
        public UserValidation ValidateUser(User user)
        {
            UserValidation validation = UserValidation.VALID;
            if (users.ContainsKey(user.Username))
            {
                validation |= UserValidation.USERNAME_TAKEN;
            }
            if (!Regex.IsMatch(user.Email, "^[a-zA-Z0-9]+([a-zA-Z0-9_]+[a-zA-Z0-9])@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+$"))
            {
                validation |= UserValidation.INVALID_EMAIL;
            }
            if (!Regex.IsMatch(user.Username, "^[a-zA-Z0-9][a-zA-Z0-9_]{2,}[a-zA-Z0-9]$"))
            {
                validation |= UserValidation.INVALID_USERNAME;
            }
            if (!Regex.IsMatch(user.Name, "^[A-ZÁ-ÚÑ][a-zá-úñ]+( [A-ZÁ-ÚÑ][a-zá-úñ]+)*$"))
            {
                validation |= UserValidation.INVALID_NAME;
            }
            if (!Regex.IsMatch(user.Surname, "^[A-ZÁ-ÚÑ][a-zá-úñ]+( [A-ZÁ-ÚÑ][a-zá-úñ]+)*$"))
            {
                validation |= UserValidation.INVALID_NAME;
            }
            return validation;
        }
    }
}