// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int rows = 10;
int cols = 10;
int [,] array = GenerateArray(rows, cols);
PrintArray(array);

Console.Write("Введите значение строки двухмерного массива (от 0 до " + (rows-1) + "): ");
int rowInput = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение столбца двухмерного массива(от 0 до " + (cols-1) + "): ");
int colInput = Convert.ToInt32(Console.ReadLine());

if (rowInput < 0 || rowInput >= array.GetLength(0)) {
    Console.WriteLine("Строки с индексом " + rowInput + " не существует");
}
else if (colInput < 0 || colInput >= array.GetLength(1)) {
    Console.WriteLine("Столбца с индексом " + colInput + " не существует");
}
else {
    Console.WriteLine("Значение элемента по координатам: [" + rowInput + ", " + colInput + "] равно: " + array[rowInput, colInput]);
}


