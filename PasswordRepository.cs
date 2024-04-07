using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    internal class PasswordRepository
    {
        private static List<Password> passwordList = new List<Password>();
        public static void AddPassword(Password password)
        {
            passwordList.Add(password);
        }

        public static void RemovePassword(Password password)
        {
            passwordList.Remove(password);
        }

        public static List<Password> GetAllPasswords()
        {
            return passwordList;
        }
    }
}
