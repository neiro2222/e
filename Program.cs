﻿using System;
class HelloWorld {

  static void Main() {
    
    Base_array[] base_Array  = new Base_array[3];
    
    Print_init();


    bool flag = bool.Parse(Console.ReadLine());
    
    Console.WriteLine("Одномерные массивы ");
    base_Array[0] = new D1_arrays(flag);     
    Console.WriteLine("Двумерные массивы ");   
    base_Array[1] = new D2_arrays(flag);
    Console.WriteLine("Ступенчатые массивы ");
    base_Array[2]= new Step_arrays(flag);

    for (int i = 0; i < base_Array.Length; i++) {
      base_Array[i].Print();
      base_Array[i].Average();
    }
    
    base_Array[0].Change(flag);
    base_Array[0].Print();
    
  }

  private static void Print_init() {
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");
  }

}
