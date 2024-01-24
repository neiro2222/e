using System;
class step_arrays {
    private int[][] Array;
    private double average;
    
    public step_arrays(int N, bool flag) {
        Array = new int[N][];
        if (flag)
        {
            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Введите размер {i + 1} строчки :");
                int m = int.Parse(Console.ReadLine());
                int[] tmp = new int[m];
                Console.WriteLine($"Введите элементы {i + 1} строчки :");
                for (int j = 0; j < m; j++) {
                    tmp[j] = int.Parse(Console.ReadLine());;
                }
            }
        } else 
        {
            random_init();
        }

        double all_size = 0;
        for (int i = 0; i < Array.Length; i++) {
            int m = Array[i].Length;
            all_size += m;
            for (int j = 0; j < m; j++) {
                average += Array[i][j];
            }
        }
        average /= all_size;

    }
    
    private void random_init() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < Array.Length; i++) {
            int m = rnd.Next(2,10);
            int[] tmp = new int[m];
            for (int j = 0; j < m; j++) {
                tmp[j] = rnd.Next(10);
            }
            Array[i] = tmp;
        }
    }
    
    public void print() {
        Console.WriteLine("Выводится размеры и элементы ступенчатого массива : ");
        Console.WriteLine($"{Array.Length} строчек");
        for (int i = 0; i < Array.Length; i++) {
            Console.Write($"размер {i+1} строчки = ");
            Console.Write(Array[i].Length);
            Console.WriteLine();
            int m = Array[i].Length;
            for (int j = 0; j < m; j++) {
                Console.Write($"{Array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
    
    public double Average {
        get
        {
            return average;
        }
    }
    
    public void change_even_el() {
        for (int i = 0; i < Array.Length; i++) {
            for (int j = 0; j < Array[i].Length; j++) {
                if (Array[i][j] % 2 == 0) {
                    Array[i][j] = i * j;
                }
            }
        }
    }
    
}