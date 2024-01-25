﻿using System;
class HelloWorld {

  static void Main() {
    Console.WriteLine("Введите размер массива : ");
    int n = int.Parse(Console.ReadLine());
    
    Print_init();

    bool flag = bool.Parse(Console.ReadLine());
    D1_arrays first = new D1_arrays(n, flag);

    first.Print();
    Console.WriteLine($"Среднее {first.Average}");
    first.Change();
    first.Print();
    first.Repeat();
    first.Print();
    
    Console.WriteLine("Введите размеры двумерного массива : ");
    int n_1 = int.Parse(Console.ReadLine());
    int m_1 = int.Parse(Console.ReadLine());

    Print_init();
    
    bool flag_1 = bool.Parse(Console.ReadLine());

    D2_arrays second = new D2_arrays(n_1, m_1, flag_1);

    second.Print();
    Console.WriteLine($"Среднее {second.Average}");
    second.Print_even_strings();

    Console.WriteLine("Введите количество строчек ступенчатого массива : ");
    int n_2 = int.Parse(Console.ReadLine());
    
    Print_init();
    
    bool flag_2 = bool.Parse(Console.ReadLine());
    Step_arrays third = new Step_arrays(n_2, flag_2);

    third.Print();
    Console.WriteLine($"Среднее {third.Average}");
    third.Change_even_el();
    third.Print();
  }

  private static void Print_init() {
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");
  }
}