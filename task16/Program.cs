// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число от 1 до 7:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number == 6 || number == 7)
    Console.WriteLine($"{number} выходной день");
else Console.WriteLine($"{number} будний день");
