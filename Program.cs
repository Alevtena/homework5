// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
        array[i] = new Random().Next(100,1000);

    return array;
}

void ShowArray (int[] array)
{
    for(int i=0; i < array.Length; i++)

        Console.Write($"[ {array[i]} , ");
    
    Console.WriteLine();
}
int CountChet(int[] array)
{
   int count = 0;
    for(int i=0; i<array.Length; i++)
    {
        if (array[i]/2==0) count +=count;
    }
    return count;
}

Console.WriteLine("Input a size of array"+" ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);
int n =  CountChet(myArray);
Console.WriteLine("Число четных элементов в массиве" + myArray + " " + n);

