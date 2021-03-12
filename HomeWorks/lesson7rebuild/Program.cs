// Decompiled with JetBrains decompiler
// Type: lesson7.Program
// Assembly: lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E8EFEA2E-4DBA-459D-B0F9-C1AA4832E327
// Assembly location: C:\Users\tsayn\Desktop\All\IT\repos\home-works\HomeWorks\lesson7\lesson7\bin\Release\netcoreapp3.1\lesson7.dll

using System;

namespace lesson7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введит сообщение для теста");
      string str = Console.ReadLine();
      Console.Clear();
      for (int i = 1; i <= 10; i++) //Меняем количество итераций цикла
        Console.WriteLine($"Вывод {i}:{str}");
    }
  }
}
