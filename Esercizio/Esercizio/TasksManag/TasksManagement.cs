using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Esercizio.TasksManag
{

    public class TasksManagement
    {


        //Vedere i Task inseriti da ArrayList
        public static void ViewAllTasks(ArrayList taskList)
        {
            foreach (Task el in taskList)
            {
                Console.WriteLine("Description: " + el.Description);
                Console.WriteLine("Deadline: " + el.Deadline.Date.ToShortDateString());
                Console.WriteLine("Level: " + el.Level);

            }
        }



        //Aggiungere un nuovo Task

        public static void AddTask(Task task, ref ArrayList taskList)
        {
            if (!task.Check()) {Console.WriteLine("Task not added"); return; }
            else   taskList.Add(task);
        }

        public static void AddTask(string description, DateTime deadline, string level, ref ArrayList taskList)
        {
         
            Task task = new Task
            {

                Description = description,
                Deadline = deadline,
                Level = level

            };
            AddTask(task, ref taskList);
        }

        //Eliminare un Task
        public static void RemoveTask(Task task, ref ArrayList taskList)
        { int n = taskList.Count;
            

            for (int i = 0; i < n; i++)
            {
               

                if (((Task)taskList[i]).Description == task.Description)
                {
                    taskList.RemoveAt(i);
                    Console.WriteLine("The task was removed");
                    i--;
                    n--;

                }
            }

        }



        // Filtrare i Task per importanza
        public static void FilterTaskLevel(string level, ArrayList taskList)
        {
            switch (level.ToLower())
            {
                case "low":
                    break;
                case "medium":
                    break;
                case "high":
                    break;
                default:
                    Console.WriteLine("Level not valid");
                    return ;
            }

            foreach (Task el in taskList)
            {

                
                if (el.Level == level)
                {
                    Console.WriteLine("Description: " + el.Description);
                    Console.WriteLine("Deadline: " + el.Deadline.Date.ToShortDateString());
                    Console.WriteLine("Level: " + el.Level);
                }

            }
            
        }

    }
}
