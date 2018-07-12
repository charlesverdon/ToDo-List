using System;
using System.Collections.Generic;

namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Task DanceClass = new Task();
            DanceClass.TaskName = "Dance Class";
            DanceClass.TaskDescription = "Learn dancing for an hour";
            //Console.WriteLine("Task: {0}\nDescription: {1}", DanceClass.TaskName, DanceClass.TaskDescription);

            // Work on creating a date time variable to get a better due date system in place
            // Goal being to have overdue, nearly due, etc. tasks and sort by them
            // DateTime dateTime = new DateTime();

            List<Task> Tasks = new List<Task>();
            Tasks.Add(new Task());
            Tasks[0].TaskName = "Dance Class";
            Tasks[0].TaskDescription = "Learn dancing for an hour!";
            Tasks.Add(new Task());
            Tasks[1].TaskName = "Toilet";
            Tasks[1].TaskDescription = "Do a poop";
            Tasks[1].CheckOff();
            Tasks[0].CheckOff();
            Tasks.Add(new Task());
            Tasks[2].TaskName = "Joopy Loopy";
            Tasks[2].TaskDescription = "Coolio Woolio Poolio";

            //Console.WriteLine(Tasks[0].ToString());
            //Console.WriteLine();
            //Console.WriteLine(Tasks[1].ToString());


            foreach (var task in Tasks)
            {
                if (task.Complete)
                {
                    Console.WriteLine(task.ToString());
                }
            }

            // First priority now is to create a way for the user to input tasks
            // And a loop to keep that up
        }
    }
}

