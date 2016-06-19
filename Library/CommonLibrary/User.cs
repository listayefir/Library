using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public Guid ID { get; set; }

        public User(Guid id, string name, string userName, string password, bool isAdmin)
        {
            ID = id;
            Name = name;
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
        }


    }
}
