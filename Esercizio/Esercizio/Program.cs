using Esercizio.FileManag;
using Esercizio.TasksManag;
using System;
using System.Collections;

namespace Esercizio
{
  
    class Program
    {
       
        static void Main(string[] args)
        {


            // Read tasks from file
            Console.WriteLine("Read tasks from file");

            ArrayList allTasks = FileManagement.GetAllTasks();
            TasksManagement.ViewAllTasks(allTasks);
            Console.WriteLine();


            //Add new task, first method
            Console.WriteLine("Add new task");

            Task task = new Task()
            {
                Description = " ...",
                Deadline = DateTime.Today.AddDays(2),
                Level = "Low"

            };
            TasksManagement.AddTask(task, ref allTasks);
            TasksManagement.ViewAllTasks(allTasks);
            Console.WriteLine();


            //Add new task, second method
            Console.WriteLine("Add new task");
            TasksManagement.AddTask("Test", DateTime.Today.AddDays(3), "low", ref allTasks);
            TasksManagement.ViewAllTasks(allTasks);
            Console.WriteLine();

            //Remove task
            Console.WriteLine("Remove task");
            TasksManagement.RemoveTask(task, ref allTasks);
            TasksManagement.ViewAllTasks(allTasks);
            Console.WriteLine();


            Console.WriteLine("Filter based on level");
            TasksManagement.FilterTaskLevel("high", allTasks);

            ////Update file
            //Console.WriteLine("Update file");
            //FileManagement.UpdateTaskFile(allTasks);

        }
           
        
    }
}
