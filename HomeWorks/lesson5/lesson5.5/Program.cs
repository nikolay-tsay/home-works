using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace lesson5._5
{
    /* Список задач (ToDo-list):
    *написать приложение для ввода списка задач;
    *задачу описать классом ToDo с полями Title и IsDone;
    *на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
    *если задача выполнена, вывести перед её названием строку «[x]»;
    *вывести порядковый номер для каждой задачи;
    *при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
    *записать актуальный массив задач в файл tasks.json/xml/bin.
    */

    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("tasks.json"))
            {
                string json = File.ReadAllText("tasks.json");
                ToDoList.List = new List<ToDo>(JsonSerializer.Deserialize<List<ToDo>>(json));
            }
            ToDoList.ShowToDoList();
            ToDoList.EditList();
            
            File.WriteAllText("tasks.json", JsonSerializer.Serialize(ToDoList.List));
        }
    }
}