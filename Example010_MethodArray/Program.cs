//Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find.
int[] array = {1, 42, 64, 54, 65, 66, 64, 77,};

int n = array.Length;
int find = 64;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}