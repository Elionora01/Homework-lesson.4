
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.WriteLine("Введите целое число. Для завершения введите 'q' или четное число:");
    string input = Console.ReadLine()!;

    if (input.ToLower() == "q") // проверка ввода пользователем
    {
        Console.WriteLine("Вы ввели 'q', программа завершена");
        break; // завершение, если это q
    }
    
    if (int.TryParse(input, out int number))
    {
        // Вычисляем сумму цифр введенного числа.
        int digitSum = CDS(number); // CDS - CalculateDigitSum, вычисляет сумму цифр числа и выводит результат на экран.

        if (digitSum % 2 == 0) // Проверка на чётность
        {
            Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
            break;
        }
        else
        {
            Console.WriteLine("Продолжайте ввод.");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод.");
    }
}
int CDS(int num) 
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10; // Получаем последнюю цифру числа и добавляем её к сумме.
        num /= 10; // Удаляем последнюю цифру из числа.
    }
    return sum;
}
