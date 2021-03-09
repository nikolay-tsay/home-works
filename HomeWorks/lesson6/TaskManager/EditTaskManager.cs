using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TaskManager
{
    public class EditTaskManager
    {
        private Process[] tasks = Process.GetProcesses();
        private int _idAction;
        private string _userAction;
        
        public void GetAllTasks()
        {
            Console.WriteLine("\tДиспетчер задач");
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}   \t\tName: {process.ProcessName}");
            }
            Console.WriteLine("Для завершения процесса введите ID или имя процесса. Для выхода введите Exit");
            
            try 
            {
                _userAction = Console.ReadLine().ToLower();
                if(_userAction == "exit")
                {
                    Console.WriteLine("Завершение программы");
                    Thread.Sleep(1000);
                    Process.GetCurrentProcess().Kill();
                }
                else if(int.TryParse(_userAction, out _idAction))
                {
                    KillById(_idAction);
                }
                else
                    KillByName(_userAction);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Вы ничего не ввели");
            }
            finally
            {
                Thread.Sleep(2000);
                GetAllTasks();
            }
        }

        private void KillById(int action)
        {
            try
            {
                Process taskById = Process.GetProcessById(action);
                taskById.Kill();
                Console.WriteLine($"Процесс с ID {action} остановлен");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Процесс с ID {action} не найден!");
            }
            finally 
            {
                Thread.Sleep(2000);
                Console.Clear();
                GetAllTasks();
            }
        }

        private void KillByName(string action)
        {
            try
            {
                Process target = tasks.First(p => p.ProcessName.ToLower() == action);
                target.Kill();
                Console.WriteLine($"Процесс под именем {action} остановлен");
            }
            catch (InvalidOperationException)
            {
                if (action == String.Empty)
                {
                    Console.WriteLine("Вы ничего не ввели");
                }
                else
                    Console.WriteLine($"Процесс с именем {action} не найден!");
            }
            finally
            {
                Thread.Sleep(2000);
                Console.Clear();
                GetAllTasks();
            }
        }
    }
}