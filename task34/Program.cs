// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
void SumEvenNumber(int[] array, out int sumN)
{
    sumN= 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
           sumN =sumN+1;
        }
        
    }
}
const int size= 9;
const int LEFT_RANGE=100;
const int RIGHT_RANGE=999;
var myArray=GenerateArray( size, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
 SumEvenNumber(myArray, out int sumoddnumber);
System.Console.Write($" количество четных  чисел в массиве = {sumoddnumber}");

 
            