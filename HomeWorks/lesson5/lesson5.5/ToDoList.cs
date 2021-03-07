using System;
using System.Collections.Generic;
using System.Threading;

namespace lesson5._5
{
    [Serializable]
    public static class ToDoList
    {
        public static List<ToDo> List = new List<ToDo>();

        public static void ShowToDoList()
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine("Список задач");
            foreach (ToDo task in List)
            {
                Console.WriteLine($"{i}.{task.Title}");
                i++;
            }
        }
        public static void EditList()
        {
            while (true)
            {
                Console.WriteLine("Для добавления задачи напишите Add\nДля пометки выполнено, напишите номер задачи\nДля выхода напишите Exit");
                string userAction = Console.ReadLine();
                int taskNum;
                if (int.TryParse(userAction, out taskNum))
                {
                    for(int i = 0; i <= List.Count; i++)
                    {
                        if (taskNum == i + 1)
                        {
                            List[i] = new ToDo() {Title = $"[x]{List[i].Title}", IsDone = true};
                        }
                        else if (taskNum > List.Count)
                        {
                            Console.WriteLine("Задачи под таким номером не существует");
                            Thread.Sleep(3000);
                            break;
                        }
                    }
                    Console.Clear();
                    ShowToDoList();
                }
                else
                {
                    if (userAction == "Add")
                    {
                        List.Add(new ToDo() {Title = Console.ReadLine(), IsDone = false});
                        ShowToDoList();
                    }
                    else if (userAction == "Exit")
                        break;
                    else
                    {
                        Console.WriteLine("Вы ввели несуществующую команду");
                        Thread.Sleep(3000);
                        Console.Clear();
                        ShowToDoList();
                    }
                }
            }
        }
    }
}