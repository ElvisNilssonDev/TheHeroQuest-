using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeroQuest_.Classes
{
    public class Hero
    {
        public string HeroName { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public Hero(string heroName, string password, string email, string phoneNumber)
        {
            HeroName = heroName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;

        }

        

    }
}
