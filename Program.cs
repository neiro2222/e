﻿using System;
class HelloWorld {

  static void Main() {
    Console.WriteLine("Введите размер массива : ");
    int n = int.Parse(Console.ReadLine());
    
    Print_init();

    bool flag = bool.Parse(Console.ReadLine());
    d1_arrays first = new d1_arrays(n, flag);

    first.print();
    Console.WriteLine($"Среднее {first.Average}");
    first.change();
    first.print();
    first.repeat();
    first.print();
    
    Console.WriteLine("Введите размеры двумерного массива : ");
    int n_1 = int.Parse(Console.ReadLine());
    int m_1 = int.Parse(Console.ReadLine());

    Print_init();
    
    bool flag_1 = bool.Parse(Console.ReadLine());

    _2d_arrays second = new _2d_arrays(n_1, m_1, flag_1);

    second.print();
    Console.WriteLine($"Среднее {second.Average}");
    second.print_even_strings();

    Console.WriteLine("Введите количество строчек ступенчатого массива : ");
    int n_2 = int.Parse(Console.ReadLine());
    
    Print_init();
    
    bool flag_2 = bool.Parse(Console.ReadLine());
    step_arrays third = new step_arrays(n_2, flag_2);

    third.print();
    Console.WriteLine($"Среднее {third.Average}");
    third.change_even_el();
    third.print();
  }

  private static void Print_init() {
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите truE");
  }
}