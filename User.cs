using System;
using System.Collections.Generic;
using System.Text;

namespace Task12
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool isPremium = false)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
    }
}