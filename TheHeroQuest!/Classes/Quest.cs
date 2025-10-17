using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeroQuest_.Classes
{
    public class Quest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }

        public bool IsCompleted { get; set; }

        public Quest(string title, string description,DateTime duedate,string priority) 
        {
            Title = title;
            Description = description;
            DueDate = duedate;
            Priority = priority;
            IsCompleted = false;
        }

        public void MarkAsComplete() 
        {
            IsCompleted = true;
            Console.WriteLine($"The {Title} quest is ==COMPLETED==");
        }

        public void ShowQuestDetails() // Method to display quest details.
        {
            Console.WriteLine($"= Title: {Title}");
            Console.WriteLine($"= Description: {Description}");
            Console.WriteLine($"= Due: {DueDate.ToShortDateString()}"); // Display only the date part of DueDate and not the time.
            Console.WriteLine($"= Priority: {Priority}");
            Console.WriteLine($"= Completed: {IsCompleted}");
            Console.WriteLine("-------------------------------");  
        }




    }
}
