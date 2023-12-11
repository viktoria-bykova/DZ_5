// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray(int rows, int cols)
{
    int[,] tempArray = new int[rows, cols];
    Random rand = new Random();

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            tempArray[i, j] = rand.Next(0, 10);
        }
    }

    return tempArray;
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

int GetRowWithMinSum(int[,] array) 
{
    int minSum = -1;
    int minSumRow = -1;
    for(int i = 0; i < array.GetLength(0); i++) {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++) {
            sum = sum + array[i,j];
        }
        if (i == 0 || sum < minSum) {
            minSum = sum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

int rows = 3;
int cols = 3;
int [,] array = GenerateArray(rows, cols);
PrintArray(array);
int rowWithMinElementsSum =  GetRowWithMinSum(array);

Console.WriteLine("Минимальная сумма элементов массива находится в строке c индексом: " + rowWithMinElementsSum);