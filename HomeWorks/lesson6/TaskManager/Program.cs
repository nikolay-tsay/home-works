using System;
using System.Diagnostics;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            EditTaskManager taskManager = new EditTaskManager();
            taskManager.GetAllTasks();
        }
    }
}