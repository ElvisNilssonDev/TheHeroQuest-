using System;
using System.Collections.Generic;

namespace TheHeroQuest_.Classes
{
    internal class Authenticator
    {
        // Simple in-memory hero storage
        private List<Hero> heroes = new List<Hero>();


        // --- Register Hero ---
        public bool RegisterHero(string heroName, string password, string email, string phoneNumber)
        {
            // Check if hero already exists
            foreach (var h in heroes)
            {
                if (h.HeroName == heroName || h.Email == email)
                {
                    Console.WriteLine("Hero already exists!");
                    return false;
                }
            }

            if (!CheckPasswordStrenght(password))
            {
                Console.WriteLine("Password is not strong enough!");
                return false;
            }
                // Create and add new hero
            Hero hero = new Hero(heroName, password, email, phoneNumber);
            heroes.Add(hero);
            Console.WriteLine($"Hero '{heroName}' is now registered");
            return true;
        }

        // --- Login Hero ---
        public Hero? LoginHero(string heroName, string password)
        {
            foreach (var h in heroes)
            {
                if (h.HeroName == heroName && h.Password == password)
                {
                    Console.WriteLine($"Welcome back, {heroName}!");
                    return h;
                }
            }

            Console.WriteLine("Incorrect hero name or password!");
            return null;
        }

        private bool CheckPasswordStrenght(string password) // Checking the password strenght. This has already been done in a previous assignment but I want to do it again.
        {
            if (password.Length < 6) return false; // Minimum length of 8 characters.
            if (!password.Any(char.IsUpper)) return false; // At least one uppercase letter.
            if (!password.Any(char.IsLower)) return false; // At least one lowercase letter.
            if (!password.Any(char.IsDigit)) return false; // At least one digit.
            if (!password.Any(ch => !char.IsLetterOrDigit(ch))) return false; // At least one special character.

            return true;
        }
    }
}






