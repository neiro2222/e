using System;
class D2_arrays {
    private int n, m;
    private int[,] array;
    private double average;
    
    public D2_arrays(int N, int M, bool flag) {
        n = N;
        m = M;
        array = new int[N, M];
        Console.WriteLine("Введите элементы массива :");
        if (flag) 
        {
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
        } else {
            Random_init(N, M);
        }

        double sum = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                sum += array[i, j];
            }
        }
        average = sum / (array.Length);
    }
    
    private void Random_init(int n, int m) {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                array[i, j] = rnd.Next(200);
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

    public void Print_even_strings() {
        Console.WriteLine("элементы четных строк в обратном порядке ");
        for (int i = 0; i < n; i++) {
            if ((i + 1) % 2 == 0) {
                for (int j = m-1; j >= 0; j--) {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            } else {
                for (int j = 0; j <  m; j++) {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public void Print() {
        Console.WriteLine("Выводится размеры и содержимое массива : ");
        Console.Write($"{n} ");
        Console.Write(m);
        Console.WriteLine();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write($"{array[i,j]} ");
            }
            Console.WriteLine();
        }
    }

}