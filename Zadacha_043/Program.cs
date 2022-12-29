// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNumber(string str)
{
    System.Console.WriteLine(str);
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}

Console.Clear();
System.Console.WriteLine("Двe прямыe, заданныe уравнениями y = k1 * x + b1, y = k2 * x + b2");
double number_b1 = EnterNumber("Введите b1");
double number_k1 = EnterNumber("Введите k1");

double number_b2 = EnterNumber("Введите b2");
double number_k2 = EnterNumber("Введите k2");

// k1 * x + b1 = k2 * x + b2 > (k1 -k2) * x = b2 - b1 > x = (b2 - b1) / (k1 -k2)
// y = k1 * x + b1 > y = k1 * (b2 - b1) / (k1 -k2) +b1

double x = (number_b2 - number_b1) / (number_k1 - number_k2);
double y = number_k1 * (number_b2 - number_b1) / (number_k1 -number_k2) +number_b1;

System.Console.WriteLine($"Точка перечесения двух прямых - [{x}, {y}]");