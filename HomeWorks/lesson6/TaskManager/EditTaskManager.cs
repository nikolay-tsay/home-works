using System;
using System.Diagnostics;
using System.Threading;

namespace TaskManager
{
    public class EditTaskManager
    {
        public void GetAllTasks()
        {
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}   \t\tName: {process.ProcessName}");
            }
            Console.WriteLine("Для завершения процесса введите ID или имя процесса. Для выхода введите Exit");
            
            string userAction = Console.ReadLine();
            int idAction;
            if (userAction == null || userAction == string.Empty)
            {
                Console.WriteLine("Вы ничего не ввели");
                Thread.Sleep(3000);
                GetAllTasks();
            }
            else if (int.TryParse(userAction, out idAction))
            {
                try
                {
                    Process tasks = Process.GetProcessById(idAction);
                    tasks.Kill();
                    Console.WriteLine($"Процесс с ID {idAction} остановлен");
                }
                catch
                {
                    throw new Exception("Процесс с таким ID не существует");
      
                }
                finally
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    GetAllTasks();
                }
            }
            else if(userAction.ToUpper() == "EXIT")
            {
                Console.WriteLine("Завершение программы");
                Thread.Sleep(3000);
            }
            else
            {
                try
                {
                    foreach (var process in Process.GetProcessesByName(userAction))
                    {
                        process.Kill();
                    }
                    Console.WriteLine($"Процесс под именем {userAction} остановлен");
                }
                catch
                {
                    throw new Exception("Процесса с такими именем не существует");
                }
                finally
                {
                    Thread.Sleep(3000);
                    Console.Clear();
                    GetAllTasks();
                }
            }
        }
    }
}