void Zadacha24()
{
    // Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
}
// Zadacha24();


void Zadacha26()
{
    // Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = num;
    int count = 0;
    while(result > 0)
    {
        result = result /10;
        count++;
    } 
    Console.WriteLine($"В заданном числе {num}: {count} цифр.");
}
// Zadacha26();


void Zadacha28()
{
    // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        sum *= i; 
    }
    Console.WriteLine($"Произведение чисел от 1 до {num} = {sum}");
}
// Zadacha28();

void Zadacha30()
{
    Random random = new Random();
    int []array = new int[8];
    int size = array.Length - 1;

    for(int i = 0; i <= size; i++)
    {
        array[i] = random.Next(0, 2);
        Console.Write(array[i] + " ");
    }
}
// Zadacha30();
