using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class _Staff
    {
        public String  name { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public _Staff(String _username, String _name, String _password)
        {
            name = _name;
            username = _username;
            password = _password;
        }
    }
}
