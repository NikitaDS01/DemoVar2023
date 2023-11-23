using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoVar2023.Classes.Database.Enum;

namespace DemoVar2023.Classes.Database.Table
{
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Role Role { get; private set; }
        public User(string login, string password, Role role)
        {
            Login = login;
            Password = password;
            Role = role;
        }
        public override string ToString()
        {
            return Login;
        }
    }
}
