using System;

// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 

int[] CreateOriginalArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void PrinttArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

int[] CreateArrayOfEvenNumbers(int count, int[] originArray)
{
    int[] arrayOfEvenNumbers = new int[count];
    int j = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
        if (originArray[i] % 2 == 0)
        {
            arrayOfEvenNumbers[j] = originArray[i];
            j++;
        }
    }
    return arrayOfEvenNumbers;
}

int minValue = -10;
int maxValue = 90;
int length = 15;

int[] originArray = CreateOriginalArray(length, minValue, maxValue);
System.Console.WriteLine("Source Array: ");
PrinttArray(originArray);
int count = CountEvenNumbersInArray(originArray);
int[] arrayOfEvenNumbers = CreateArrayOfEvenNumbers(count, originArray);
Console.WriteLine("Array of even numbers: ");
PrinttArray(arrayOfEvenNumbers);