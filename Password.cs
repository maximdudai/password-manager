using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password_manager
{
    internal class Password
    {
        private string password;
        private string username;
        private string website;

        public Password(string password, string username, string website)
        {
            this.password = password;
            this.username = username;
            this.website = website;
        }

        public string getPassword()
        {
            return this.password;
        }
        public string getUsername()
        {
               return this.username;
        }
        public string getPlatform()
        {
            return this.website;
        }

    }
}
