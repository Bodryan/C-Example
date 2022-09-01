// Вид 1. Метод ничего не возвращают и ничего не принимают.

void Method1() // в данном методе отсутвтсвую аргументы.
{
    Console.WriteLine(" Автор ...");
}
// Method1(); // вызов метода.



// Вид 2. Ничего не возвращают, но принимают какие то аргументы.
void Method2(string msg) // прописали в методе аргумент "msg" с типом данных "string"
{
    Console.WriteLine(msg); // в теле прописали вывести в консоль аргуемент "msg"
}
// Method2("текст");

// пример метода где используется более одного аргумента
void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
// Method2_1("Текст", 10); // прописал значения к первому аргументу "msg" и воторому аргументу "count"
// Method2_1(count: 4, msg: "хочу так"); // явно прописал аргумент: и его значение. Можно прописывать не по порядку.



//Вид 3. Что-то возвращают, но ничего не принимают
int Method3() //обязательно укзываем тип данных перед названием метода. Аргументы данный метод не принимает
{
    return DateTime.Now.Year; // обязательное использование оператора "return"
}

int date = Method3(); // указали переменную и через знак присваивания "=" прописали результат работы "Method3()"
// Console.WriteLine(date);



// Вид 4. Что-то принимает и что-то возпращает.
string Method4(int count, string d)
{
    int i = 0;
    string result = String.Empty; // значение "String.Empty" обозначает что строка будет пустой

    while (i < count)
    {
        result = result + d; // в переменную "result" при выполнения цикла будет присваиваться значение конкатенации(склеивания) переменных "result" + "d"
        i++;
    }
    return result; // в конце цикла прописали оператор "return" который будет возвращать переменную "result"
}

string res = Method4(10, "b"); // для вывода метода, прописываем переменную и вкладываем результат работы "Method4" указав значения введенных аргументов "count" и "string"
// Console.WriteLine(res);


// таблица умножения используя цикл в цикле "for"

/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
    Console.WriteLine();
}
*/


// Зача. Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить маленькими “с”.

string text = "— Я думаю, — казал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }


    return result;
}

/*
string newText = Replace(text, ' ', '|');

newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'с', 'С');

Console.WriteLine(newText);
Console.WriteLine();
*/

int[] arr = {5, 4, 0, 4, 1, 1, 2, 12, 99, 2, 3, 6, 8};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// PrintArray(arr);

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);

PrintArray(arr);