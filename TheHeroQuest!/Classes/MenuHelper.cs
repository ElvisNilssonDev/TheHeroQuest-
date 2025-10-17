using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeroQuest_.Classes
{
    public class MenuHelper
    {
        public static void ShowMainMenu()
        {
            Hero? ActiveHero = null;
            bool running = true;
            Authenticator authenticator = new Authenticator();
            while (running)
            {
                Console.WriteLine("\n Guild Terminal ");
                Console.WriteLine("1. Register hero");
                Console.WriteLine("2. Login hero");
                Console.WriteLine("3. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("What Legacy do you wanna leave behind?");
                        Console.WriteLine("Enter Your HeroName:");
                        string heroName = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter Your Password:");
                        string password = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter Your Email:");
                        string email = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter your phonenumber");
                        string phoneNumber = Console.ReadLine() ?? "";

                        if (authenticator.RegisterHero(heroName,password,email,phoneNumber))
                        {
                            Console.WriteLine("Successful");
                        }
                        else
                        {
                            Console.WriteLine("Something wnet wrong");
                        }

                            // Registration logic should be here (not shown in original code)
                        break;
                    case "2":
                        Console.WriteLine("Welcome back Hero!");
                        Console.WriteLine("Enter Your HeroName so I can book you in:");
                        string loginHeroName = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter Your Password:");
                        string loginPassword = Console.ReadLine() ?? "";

                        ActiveHero = authenticator.LoginHero(loginHeroName, loginPassword);
                        if (ActiveHero != null)
                        {
                            Console.WriteLine($"Welcome back {loginHeroName}! how was your travels?");
                            ShowHeroMenu(ActiveHero);
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting TheHeroQuest!. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Wrong choice!");
                        break;
                }
            }
        }

        private static void ShowHeroMenu(Hero hero)
        {
            QuestManager questmanager = new QuestManager();
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.WriteLine($"\n Welcome, {hero.HeroName}!");
                Console.WriteLine("1. Add quest");
                Console.WriteLine("2. View quests");
                Console.WriteLine("3. Complete quest");
                Console.WriteLine("4. Update quest");
                Console.WriteLine("5. Show report");
                Console.WriteLine("6. Logout");
                Console.Write("Choose: ");
                string c = Console.ReadLine()!;
            }
            //switch (c) :This will be the part where the hero can manage quests but its yet to be implemented.
            //{
            //case "1": questmanager.AddQuest(); break;
            //case "2": questmanager.ShowAllQuests(); break;
            //case "3": questmanager.CompleteQuest(); break;
            //case "4": questmanager.UpdateQuest(); break;
            //case "5": questmanager.GetReport(); break;
            //case "6": loggedIn = false; break;
            //default: Console.WriteLine("Wrong choice!"); break;
            // }
        }
    }
}
        
    



