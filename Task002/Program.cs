/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine() ??"");

if (numberOne > numberTwo)
{
    int max = numberOne;
    Console.WriteLine($"Первое число {numberOne} больше второго {numberTwo}");
}
else if (numberTwo > numberOne)
{
    int max = numberTwo;
    Console.WriteLine($"Второе число {numberTwo} больше первого {numberOne}");
}
else if (numberOne == numberTwo)
{
    Console.WriteLine ("Эти числа равны");
}