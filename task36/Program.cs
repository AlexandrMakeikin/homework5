// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(",", array) + "]");
}
void SumElements(int[] array, out int sumN)
{
    sumN= 0;
    
    for (int i = 1; i < array.Length; i=i+2)
    {
        sumN+=array[i];
    }
}

var myArray=GenerateArray( 4, -10, 10);
PrintArray(myArray);
SumElements(myArray, out int sumN);
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях :{sumN}");
