using System;
sealed class Step_arrays : Base_array {
    private int[][] array;
    
    public Step_arrays(bool flag) {
        Create_array(flag);
    }
    
    public override void Create_array(bool flag) {
        Console.WriteLine("Введите количество строчек ступенчатого массива : ");
        int n = int.Parse(Console.ReadLine());
        array = new int[n][];
        if (flag) 
        {
            _Key_init();
        } else {
            _Random_init();
        }
    }

    public void Change(int new_n, bool flag) {
        Create_array(flag);
    }

    protected override void _Key_init() {
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine($"Введите размер {i + 1} строчки :");
            int m = int.Parse(Console.ReadLine());
            int[] tmp = new int[m];
            Console.WriteLine($"Введите элементы {i + 1} строчки :");
            for (int j = 0; j < m; j++) {
                tmp[j] = int.Parse(Console.ReadLine());;
            }
        }
    }

    protected override void _Random_init() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++) {
            int m = rnd.Next(2,10);
            int[] tmp = new int[m];
            for (int j = 0; j < m; j++) {
                tmp[j] = rnd.Next(10);
            }
            array[i] = tmp;
        }
    }
    
    public override void Print() {
        Console.WriteLine("Выводится размеры и элементы ступенчатого массива : ");
        Console.WriteLine($"{array.Length} строчек");
        for (int i = 0; i < array.Length; i++) {
            Console.Write($"размер {i+1} строчки = ");
            Console.Write(array[i].Length);
            Console.WriteLine();
            int m = array[i].Length;
            for (int j = 0; j < m; j++) {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
    
    public override void Average() {

            double average = 0;
            double all_size = 0;
            for (int i = 0; i < array.Length; i++) {
                int m = array[i].Length;
                all_size += m;
                for (int j = 0; j < m; j++) {
                    average += array[i][j];
                }
            }
            average /= all_size;
            Console.WriteLine($"Среднее {average}");
    }
    
    public void Change_even_el() {
        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array[i].Length; j++) {
                if (array[i][j] % 2 == 0) {
                    array[i][j] = (i+1) * (j+1);
                }
            }
        }
    }

    public override void Inf() {
        Console.WriteLine("Ступенчатый массив");
    }
    
}