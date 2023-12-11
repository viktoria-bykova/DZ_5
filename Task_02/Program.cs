//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GenerateArray(int rows, int cols)
{
    int[,] tempArray = new int[rows, cols];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            tempArray[i, j] = rand.Next(0, 100);
        }
    }

    return tempArray;
}

int[,] ChangeFirstAndLastRow(int[,] array) 
{
    for(int i = 0; i < array.GetLength(1); i++) {
        int firstRowItemValue = array[0,i];
        array[0,i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = firstRowItemValue;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) {
        int[] internalArray = new int[array.GetLength(1)];
        for(int j = 0; j < array.GetLength(1); j++) {
            internalArray[j] = array[i,j];
        }
        Console.WriteLine("[" + string.Join(", ", internalArray) + "]");        
    }
}

int rows = 5;
int cols = 10;
int [,] array = GenerateArray(rows, cols);
Console.WriteLine("Исходный массив");
PrintArray(array);

int [,] array2 = ChangeFirstAndLastRow(array);
Console.WriteLine("Массив с поменянной первой и последней строкой");
PrintArray(array2);