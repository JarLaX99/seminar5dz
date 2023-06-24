// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void main()
{
    int sizeArray = Readint("Введите размер массива: ");
    int[] array = FillArray(sizeArray);
    PrintArray(array);
    PrintResult(NumberEven(array));
}

int[] FillArray(int size = 10, int leftRange = 100, int rightRange = 1000)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

int NumberEven(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}
int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join("] [", arrayForPrint) + "]");
}

void PrintResult(int NumberEven)
{
    if (NumberEven > 4)
    {
        System.Console.WriteLine($"В данном массиве {NumberEven} четных чисел");
    }
    else if (NumberEven > 1 && NumberEven < 5) 
    {
        System.Console.WriteLine($"В данном массиве {NumberEven} четных числа");
    }
    else if(NumberEven == 1)
    {
        System.Console.WriteLine($"В данном массиве Одно четное число");
    }
    else 
    {
        System.Console.WriteLine("Четных чисел нет");
    }
}

main();