// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int[,] array = new int[3,5];
Console.WriteLine("Первичный массив: ");
Console.WriteLine();
GetArray(array);
PrintArray(array);
int minSum = 0;
int sum2 = 0;
Console.WriteLine();
Console.WriteLine($"\nСтрока с наименьшей суммой: {SumRow(array)}");

void GetArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] sumRowArray)
{
    for (int i = 0; i < sumRowArray.GetLength(0); i++)
    {
        for (int j = 0; j < sumRowArray.GetLength(1); j++)
        {
            Console.Write($"{sumRowArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumRow(int [,] sumRowArray)
{
    int row = 0;
    for (int i = 0; i < sumRowArray.GetLength(1); i++)                        
    {
        minSum = minSum + sumRowArray[0, i];
    }
    Console.Write($"{minSum} ");
    for (int i = 1; i < sumRowArray.GetLength(0); i++)  
    {   
        for (int j = 0; j < sumRowArray.GetLength(1); j++)
        {                    
            sum2 = sum2 + sumRowArray[i, j];    
        }    
        Console.Write($"{sum2} ");
        if(minSum>sum2)
        {
            minSum = sum2;
            row = i;
        }
    }
    return row+1;
}

