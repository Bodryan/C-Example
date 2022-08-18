void Zadacha17()
{
    // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
    Random random = new Random();
    int x = random.Next(-10, 11);
    int y = random.Next(-10, 11);
    Console.WriteLine($"точка с координатами ({x}, {y})");
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1 четверть");
    }
    else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
    else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
    else Console.WriteLine("точка лежит на оси координат");
}

//  Zadacha17();

void Zadacha18()
{
    // Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

    Random random = new Random();
    int quarter = random.Next(1, 5);
    Console.WriteLine($"Четверть ({quarter})");

    if (quarter == 1)
    {
        Console.WriteLine($"В первой четверти диапазон координат будет равен где x > 0, y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine($"Во второй четверти диапазон координат будет равен где x < 0, y > 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine($"В третьей четверти диапазон координат будет равен где x < 0, y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine($"В четвертой четверти диапазон координат будет равен где x > 0, y < 0");
    }
}

// Zadacha18();

void Zadacha21()
{
    // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

    Random random = new Random();
    int xa = 7,// random.Next(-10, 11),
        xb = 1,// random.Next(-10, 11),
        ya = -5,// random.Next(-10, 11),
        yb = -1;// random.Next(-10, 11);
    Console.WriteLine($"Даны координаты двух точек: ({xa}, {ya}) и ({xb}, {yb})");

    double Distance(int arg1, int arg2, int arg3, int arg4)
    {
        int rezultA = (arg1 - arg3) * (arg1 - arg3);
        int rezultB = (arg2 - arg4) * (arg2 - arg4);
        double rezultC = Math.Sqrt(rezultA + rezultB);
        
        Console.WriteLine($"Расстояние межде двух точек равно: {rezultC}");
        return rezultC;
    }
    Distance(xa, ya, xb, yb);
}

// Zadacha21();

void Zadacha22()
{

    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
    Console.Write("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
        int rezult = i * i;
        Console.WriteLine(rezult);
    }
}
// Zadacha22();
