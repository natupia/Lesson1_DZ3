// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int Number1 = Convert.ToInt32(Console.ReadLine());
if (Number1 % 2 == 0)
{
Console.WriteLine($"{Number1} является чётным числом");
}
else
{
Console.WriteLine($"{Number1} является нечётным числом");
}