using System;
sealed class D1_arrays : Base_array {
    private int[] a;
    
    public D1_arrays(bool flag) {
        Create_array(flag);
    }

    private void Create_array(bool flag) {
        Console.WriteLine("Введите размер массива : ");
        int n = int.Parse(Console.ReadLine());
        a = new int[n];
        if (flag) {
            _Key_init();
        } else {
            _Random_init();
        }
    }
    
    public override void Change(bool flag) {
        Console.WriteLine("Массив изменен");
        Create_array(flag);
    }
    
    protected override void _Key_init() {
        Console.WriteLine("Введите элементы массива :");
        for (int i = 0; i < a.Length; i++) {
            a[i] = int.Parse(Console.ReadLine());
        }
    }

    protected override void _Random_init() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        for (int i = 0; i < a.Length; i++) {
            a[i] = rnd.Next(200);
        }
    }
    
    public override void Print() {
        Console.WriteLine("Выводится размер и содержимое массива : ");
        Console.WriteLine(a.Length);
        for (int i = 0; i < a.Length; i++) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
    }
    
    public override void Average() {
        double average = 0;
        for (int i = 0; i < a.Length; i++) {
            average += a[i];
        }
        average /= a.Length;
        Console.WriteLine($"Среднее {average}");
    }
    
    public void More_than_100() {
        int[] tmp = new int[a.Length];
        int s = 0;
        int j = 0;
        for (int i = 0; i < a.Length; i++) {
            if (Math.Abs(a[i]) < 100) {
                s += 1;
                tmp[j] = a[i];
                j++;
            }
        }
        Array.Resize(ref a, s);
        for (int i = 0; i < s; i++) {
            a[i] = tmp[i];
        }
        Console.WriteLine("Удалены элементы по модулю больше 100");
        Console.WriteLine("Новый массив : ");
    }
    
    public void Repeat() {
        const int inf = 100000;
        Array.Sort(a);
        int pred = inf;
        int[] tmp = new int[a.Length];
        int s = 0;
        for (int i = 0; i < a.Length; i++) {
            if (a[i] != pred) {
                tmp[s] = a[i];
                s += 1;
                pred = a[i];
            }
        }
        Array.Resize(ref a, s);
        for (int i = 0; i < s; i++) {
            a[i] = tmp[i];
        }
        Console.WriteLine("Удалены повторяющиеся элементы ");
        Console.WriteLine("Новый массив : ");
    }

    public override void Inf() {
        Console.WriteLine("Одномерный массив");
    }

}