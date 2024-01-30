﻿using System;
class HelloWorld {

  static void Main() {
    
    Console.WriteLine("Одномерные массивы ");
    
    Print_init();

    bool flag = bool.Parse(Console.ReadLine());
    D1_arrays first = new D1_arrays(flag);

    first.Print();
    first.Average();
    first.More_than_100();
    first.Print();
    first.Repeat();
    first.Print();
    
    Console.WriteLine("Двумерные массивы ");

    Print_init();
    
    bool flag_1 = bool.Parse(Console.ReadLine());

    D2_arrays second = new D2_arrays(flag_1);

    second.Print();
    second.Average();
    second.Print_even_strings();

    Console.WriteLine("Ступенчатые массивы ");
    
    Print_init();
    
    bool flag_2 = bool.Parse(Console.ReadLine());
    Step_arrays third = new Step_arrays(flag_2);

    third.Print();
    third.Average();
    third.Change_even_el();
    third.Print();
  }

  private static void Print_init() {
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");
  }
}
