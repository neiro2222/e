using System;
sealed class D2_arrays : Base_array {
    private int[,] array;
    public D2_arrays(bool flag) {
        Create_array(flag);
    }
    protected override void Create_array(bool flag) {
        Console.WriteLine("Введите размеры двумерного массива : ");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        array = new int[n, m];
        if (flag) 
        {
            _Key_init();
        } else {
            _Random_init();
        }
    }
    
    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }

    protected override void _Key_init()
    {
        Console.WriteLine("Введите элементы массива :");
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    protected override void _Random_init() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                array[i, j] = rnd.Next(200);
            }
        }
    }
    
    public override void Average()
    {
        double average = 0;
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                average += array[i, j];
            }
        }
        average /= array.Length;
        Console.WriteLine($"Среднее {average}");
    }    

    public void Print_even_strings() {
        Console.WriteLine("Элементы четных строк в обратном порядке ");
        for (int i = 0; i < array.GetLength(0); i++) {
            if ((i + 1) % 2 == 0) {
                for (int j = array.GetLength(1)-1; j >= 0; j--) {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            } else {
                for (int j = 0; j <  array.GetLength(1); j++) {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public override void Print() {
        Console.WriteLine("Двумерный массив");
        Console.WriteLine("Выводится размеры и содержимое массива : ");
        Console.Write($"{array.GetLength(0)} ");
        Console.Write(array.GetLength(1));
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }



}