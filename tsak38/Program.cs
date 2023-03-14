// : Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GenerateArray( )

{Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]  = Convert.ToDouble(new Random().Next(10,100)) / 10;
    }
    return array;
}
void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(" ; ", array) + "]");
}
void Flip(double[] array, out double minElement, out double maxELement)
{

    minElement =array[0];
    maxELement = array[0];
    for (int i = 0; i < array.Length; i++)

    {

        if (array[i] > maxELement)
        {
            maxELement = array[i];
        }
         if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
}

var myArray = GenerateArray();

Flip(myArray,out double minElement, out double maxELement);
PrintArray(myArray);
Console.WriteLine($" Максимальное значение = {maxELement}, минимальное значение = {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {maxELement- minElement}");


