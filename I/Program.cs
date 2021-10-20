using System;

namespace I
{
    class Developer : ILead
    {
        public void AssignTask() => throw new Exception("Developer can't Assign Task");

        public void CreateTask() => throw new Exception("Developer can't Create Task");

        public void WorkOnTask()
        {
            /* Code to work on a task*/
        }
    }

    public interface ILead
    {
        void CreateTask();
        void AssignTask();
        void WorkOnTask();
    }
    class Lead : ILead
    {
        public void AssignTask()
        {

        }

        public void CreateTask()
        {

        }

        public void WorkOnTask()
        {

        }
    }
    class Manager : ILead
    {
        public void AssignTask()
        {

        }

        public void CreateTask()
        {
 
        }

        public void WorkOnTask() => throw new Exception("Manager can't work on Task");
    }
}
