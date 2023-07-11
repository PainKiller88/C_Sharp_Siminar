// Написать программу которая на вход принимает число и выдает его квадрат


// Например 
// 4 -> 16
// 3 -> 9
// 7 -> 14

Console.Clear();
Console.Write ("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
int result = num1 * num1;
Console.WriteLine($"Квадрат числа {num1} равен {result}" );