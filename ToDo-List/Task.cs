using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_List
{
    class Task
    {
        public string TaskName;
        public string TaskDescription;
        public Boolean Complete = false;


        public void CheckOff()
        {
            Complete = true;
        }

        public override string ToString()
        {
            if (Complete)
            {
                return String.Format("Task: {0}\nDescription: {1}\nComplete: [x]\n", TaskName, TaskDescription);
            }
            else
            {
                return String.Format("Task: {0}\nDescription: {1}\nComplete: [ ]\n", TaskName, TaskDescription);
            }

        }
    }
}
