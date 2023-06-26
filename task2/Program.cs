// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void main()
{
    int sizeArray = Readint("Введите размер массива: ");
    int[] array = FillArray(sizeArray);
    PrintArray(array);
    System.Console.WriteLine("сумма элементов стоящих на нечетных позициях = "+SumOdd(array));
}
int[] FillArray(int size = 10, int leftRange = -100, int rightRange = 100)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
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

int SumOdd(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum+=arr[i];
    }
    return sum;
}
main();