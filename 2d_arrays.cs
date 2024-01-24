using System;
class _2d_arrays {
    private int n, m;
    private int[,] Array;
    private double average;
    
    public _2d_arrays(int N, int M, bool flag) {
        n = N;
        m = M;
        Array = new int[N, M];
        Console.WriteLine("Введите элементы массива :");
        if (flag) 
        {
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    Array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        } else {
            random_init(N, M);
        }

        double sum = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                sum += Array[i, j];
            }
        }
        average = sum / (Array.Length);
    }
    
    private void random_init(int n, int m) {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Array[i, j] = rnd.Next(200);
            }
        }
    }
    
    public double Average
    {
        get
        {
            return average;
        }
    }    

    public void print_even_strings() {
        Console.WriteLine("элементы четных строк в обратном порядке ");
        for (int i = 0; i < n; i++) {
            if ((i + 1) % 2 == 0) {
                for (int j = m-1; j >= 0; j--) {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();
            } else {
                for (int j = 0; j <  m; j++) {
                    Console.Write($"{Array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public void print() {
        Console.WriteLine("Выводится размеры и содержимое массива : ");
        Console.Write($"{n} ");
        Console.Write(m);
        Console.WriteLine();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write($"{Array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

}