// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] FillArray(int size)
{
    int[] array = new int[size];
  
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] inputArray) // метод для вывода эл-в в консоль
{
    Console.Write("Массив с элементами: ");

    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write(inputArray[i] + " ");
    }
}

void chet(int[] num) 
{
    int[] firstNumbers = new int[num.Length];
    
    Console.WriteLine(); 

    Console.Write("Элементы массива, значения которых четное: "); 

    int countOfFirstNumbers = 0;

    for (int i = 0; i < num.Length; i++) 
    {
        if (num[i] % 2 == 0) 
        {
            Console.Write(num[i] + " ");
            
            firstNumbers[countOfFirstNumbers] = num[i];
            countOfFirstNumbers++;
        }
    }

    Console.WriteLine();

    Console.WriteLine($"Количество чётных чисел в массиве: {countOfFirstNumbers}");
}

int SizaArr = 15;
int[] Arr = FillArray(SizaArr);
PrintArray(Arr);
chet(Arr);
