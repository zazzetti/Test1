using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Esercizio.FileManag
{
    public class FileManagement
    {


        public static string path { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Test-Modulo1/Tasks.csv");


        // Da File a ArrayList
        public static ArrayList GetAllTasks()
        {
            int totalLines = File.ReadLines(path).Count();
            ArrayList taskList = new ArrayList(totalLines - 1);

            string line;
            using (StreamReader reader = File.OpenText(path))
            {
                string header = reader.ReadLine();

                for (int i = 0; i < totalLines - 1; i++)
                {
                    line = reader.ReadLine();
                    string[] taskData = line.Split(",");
                    if (!DateTime.TryParse(taskData[1], out DateTime dt))
                        throw new Exception("Not possible to convert deadline to DateTime");

                    Task task = new Task
                    {

                        Description = taskData[0],
                        Deadline = dt.Date,
                        Level = taskData[2]

                    };
                    if (!task.Check())
                    {
                        Console.WriteLine("Task not valid");
                        continue;
                    }else
                        taskList.Add(task);
                }

                return taskList;

            }
        }

        //Da arraylist a file
        public static void UpdateTaskFile(ArrayList taskList)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine("Description,Deadline,Level");

                foreach (Task t in taskList)
                {
                    writer.WriteLine(t.Description + "," + t.Deadline.Date + "," + t.Level);
                }
            }
        }
    }
}
