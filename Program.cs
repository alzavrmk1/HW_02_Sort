namespace HW02_SortArray;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = { { 1, 9, 3 }, { 4, 2, 8 }, { 5, 6, 7 } };
        Console.WriteLine("Двумерный массив до сортировки");
        printArray2D(a);
        Console.WriteLine();

        int[] arrayLine = new int[9];
        arrayLine = convertArrayInLine(a);
        sort(arrayLine);
      
        a = convertArrayLineIn2D(arrayLine, 3, 3);
        Console.WriteLine("Двумерный массив после сортировки");
        printArray2D(a);
    }
    // Конвертируем двумерный массив в одномерный
    static int[] convertArrayInLine(int[,] array)
    {
        int m = array.GetLength(0);
        int n = array.GetLength(1);
        int index = 0;
        int[] arrayLine = new int[m * n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arrayLine[index] = array[i, j];
                index++;
            }
            
        }
        return arrayLine;
    }

    static void sort(int[] array)
    {
        int temp = 0;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length - 1 - j; i++)
            {
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
          
        }
   }
    //Конвертируем линейный массив в двумерный размерности m*n
    static int[,] convertArrayLineIn2D(int[] array, int m, int n)
    {
        int[,] array2D= new int[m, n];
        int arrayLength = array.Length;
        int index = 0;
       
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array2D[i, j] = array[index];
                index++;
                if (index > arrayLength)
                    break;
                }
        }
        return array2D;
    }

    //Метод печати двумерного массива
    static void printArray2D(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
            }
            Console.WriteLine();
        }
    }

    //Метод печати одномерного массива
    static void printArrayLine(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

}
