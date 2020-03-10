using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class LoginDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool AuthDetails { get; set; }

        public LoginDetails(string username, string password, bool authDetails)
        {
            this.Username = username;
            this.Password = password;
            this.AuthDetails = authDetails;
        }
        public LoginDetails()
        {

        }
    }
}
