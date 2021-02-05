using System;
using System.Collections.Generic;
using System.Text;

namespace Esercizio
{
    public class Task
    {
       

        public string Description { get; set; }
        public DateTime Deadline { get; set; }

        public string Level { get; set; }

   
        public bool Check(){
            if (Deadline < DateTime.Now)
            {
                Console.WriteLine("Date not valid");
                return false;
            }

            switch (Level.ToLower())
            {
                case "low":
                    break;
                case "medium":
                    break;
                case "high":
                    break;
                default:
                    Console.WriteLine("Level not valid");
                    return false;
            }

            return true;

        }



       
    }
}
