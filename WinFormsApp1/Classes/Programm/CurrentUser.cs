using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoVar2023.Classes.Database.Table;

namespace DemoVar2023.Classes.Programm
{
    public class CurrentUser
    {
        private static User _user = null;
        private static bool _isUserEmpty = true;
        public static void SetUser(User userIn)
        {
            _user = userIn;
            _isUserEmpty = false;
        }
        public static User GetUser()
        {
            if (_isUserEmpty)
                return null;
            return _user;
        }
    }
}
