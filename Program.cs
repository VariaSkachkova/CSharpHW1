internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 2: Напишите программу, которая на вход принимает два числа
        // и выдаёт, какое число большее, а какое меньшее.
        Console.WriteLine("Задача 2");
        Console.WriteLine("Введите первое целое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if (number1 > number2)
        {
            Console.WriteLine($"Первое число {number1} больше второго числа {number2}");
        }
        else if (number1 == number2)
        {
            Console.WriteLine($"Первое число {number1} равно второму числу {number2}");
        }
        else
        {
            Console.WriteLine($"Второе число {number2} больше первого числа {number1}");
        }
        //Задача 4: Напишите программу, которая принимает на вход 
        //три числа и выдаёт максимальное из этих чисел.
        Console.WriteLine("Задача 4");
        Console.WriteLine("Введите первое целое число: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе целое число: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье целое число: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int max = number1;
        if (number2 > max) max = number2;
        if (number3 > max) max = number3;
        Console.WriteLine($"Самое большое число – {max}");

        //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
        //является ли число чётным (делится ли оно на два без остатка).

        Console.WriteLine("Задача 6");
        Console.WriteLine("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"Число {number} – четное");
        }
        else
        {
            Console.WriteLine($"Число {number} – нечетное");
        }

        //Задача 8: Напишите программу, которая на вход принимает число (N),
        //а на выходе показывает все чётные числа от 1 до N.

        Console.WriteLine("Задача 8");
        Console.WriteLine("Введите целое число: ");
        number = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (count <= number)
        {
            if (count % 2 == 0)
            {
                Console.Write(count + "  ");
            }
            count++;
        }
    }
}