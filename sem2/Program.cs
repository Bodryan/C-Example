void Zadacha9()
{
    // 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    
    //83
    int ones = number % 10;
    int tens = number / 10;


    if(ones > tens) Console.WriteLine(ones);
    else Console.WriteLine(tens);
}
// Zadacha9();

void Zadacha11()
{
    // 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

    Random rand = new Random();
    int number = rand.Next(100,1000);
    Console.WriteLine(number);

    int ones = number % 10;
    int hund = number / 100;
    Console.WriteLine(hund * 10 + ones);
}

// Zadacha11();

void Zadacha12()
{
    // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

    Random rand = new Random();
    int num1 = rand.Next(1,100);
    int num2 = rand.Next(1,100);
    Console.WriteLine("Даны два числа" + " " + num1 + "; " + num2);

    if (num2 % num1 == 0) Console.WriteLine("Число " + num2 + " кратно" + " " + num1);
    else Console.WriteLine("Число " + num2 + " не кратно" + " " + num1);
}
// Zadacha12(); 

void Zadacha14()
{
    // Напишите программу, которая принимает навход число и проверяет, кратно ли оноодновременно 7 и 23.
    Random rand = new Random();

    for (int i = 1; i < 10; i++)
    {
        int num = 161;
        Console.WriteLine("Дано число " + num);
        if (num % 7 == 0 && num % 23 == 0) Console.WriteLine(num + " Является кратным 7 и 23");
        else Console.WriteLine(num + " Не является кратным 7 и 23");
    }

}

// Zadacha14();

void Zadacha16()
{
    // Напишите программу, которая принимает навход два числа и проверяет, является ли одно число квадратом другого.

    Random rand = new Random();
    

    Console.WriteLine("Введите первое число");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Даны два числа " + num1 + " и " + num2);

    if (num2 == num1 * num1 || num1 == num2 * num2)
    {
        if (num2 == num1 * num1)
        {
            Console.WriteLine("Число " + num1 + " является квадтратом числа " + num2);
        }
        else Console.WriteLine("Число " + num2 + " является квадтратом числа " + num1);
            
    } 
    else Console.WriteLine("Ни одно число не является квадтратом другого");
}

// Zadacha16();