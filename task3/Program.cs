// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void main()
{
    int sizeArray = Readint("Введите размер массива: ");
    double[] array = FillArray(sizeArray);
    PrintArray(array);
    System.Console.WriteLine("Разница между максимальным и минимальным числом = " + Math.Round(DifferenceMaxMin(array),3));
}
double[] FillArray(int size = 10, int leftRange = -10, int rightRange = 100)
{
    double[] tempArray = new double[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }

    return tempArray;
}

int Readint(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join("] [", arrayForPrint) + "]");
}

double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double result = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    result = max - min;
    return result;
}
main();