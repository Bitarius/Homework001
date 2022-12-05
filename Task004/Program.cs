/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Введите третье число");
int numberThree = int.Parse(Console.ReadLine() ??"");

int maxNumber = numberOne;

if (maxNumber < numberTwo)
{
    maxNumber = numberTwo;
}

if (maxNumber < numberThree)
{
    maxNumber = numberThree;
}

Console.WriteLine(maxNumber);
