// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33] 

int[] array(int Length = 8)
{
    int[] tempArray = new int[Length];
    for(int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random(). Next();
    }
    return tempArray;
}
void PrintArray(int[] intArray)
{
     for(int i = 0; i < intArray.Length; i++)
    {
        System.Console.WriteLine(value: $"{intArray[i]}");
    }
    
}


System.Console.WriteLine("случайный массив длинной 8 ");
PrintArray(intArray: array());