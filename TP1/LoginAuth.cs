using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class LoginAuth
    {
        private readonly string pass = "pbo123";

        public bool LoginCheck(LoginDetails loginDetails)
        {
            if (loginDetails.Password == this.pass)
            {
                if (loginDetails.Username != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
