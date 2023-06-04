string[] discipline = new string[3] { "Информатика", "Разработка игр", "Основы алгоритмизации" };

int[] studentNumber = new int[] { 1, 2, 3, 4, 5 };

int[] marksInf = new int[5];

int[] marksDev = new int[5];

int[] marksAlg = new int[5];

Console.WriteLine($"Оценки по дисциплине {discipline[0]}");

for (int a = 1, i = 0; i < 5; i++, a++)
{
    Console.WriteLine($"Введите оценку для {a} ученика: ");
    marksInf[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Оценки по дисциплине {discipline[1]}");

for (int a = 0, t = 1; a < 5; a++, t++)
{
    Console.WriteLine($"Введите оценку для {t} ученика: ");
    marksDev[a] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Оценки по дисциплине {discipline[2]}");

for (int f = 0, a = 1; f < 5; f++, a++)
{
    Console.WriteLine($"Введите оценку для {a} ученика: ");
    marksAlg[f] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

foreach (string u in discipline)
{
    Console.Write("  " + "|" + u + "|");
}

Console.WriteLine();

for (int f = 0; f < 5; f++)
{
    Console.WriteLine(studentNumber[f] + "." + "  " + marksInf[f] + "             " + marksDev[f] + "                 " + marksAlg[f]);
}
Console.WriteLine("\nНажмите любую клавишу для перехода на следующее задание");
Console.ReadKey();
Console.Clear();
// 2 Задание 
Console.Write("Введите количество элементов для массива: ");
int userInput = int.Parse(Console.ReadLine());
int[] result = new int[userInput];

for (int i = 0; i < result.Length; i++)
{
    Console.Write($"Введите элементы массива под индексом {i}: ");
    result[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВсе элементы массива: ");
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}
Console.WriteLine("\nВсе элементы массива в обратном порядке: ");
for (int i = result.Length - 1; i >= 0; i--)
{
    Console.Write(result[i] + " ");
}
Console.WriteLine("\nВсе элементы массива через 1: ");
for (int i = 0; i < result.Length; i += 2)
{
    Console.Write(result[i] + " ");
}
Console.WriteLine("\nВсе элементы массива, пока не встретится -1: ");
for (int i = 0; i < result.Length; i++)
{
    int element = result[i];

    if (element == -1)
        break;

    Console.Write(element + " ");
}

Console.WriteLine();

Console.WriteLine("\nНажмите любую клавишу для перехода на следующее задание");
Console.ReadKey();
Console.Clear();

// Задание 3
string[] days = { "1 день", "2 день", "3 день", "4 день" };
int[,] temperature =
{
    {-8,-14,-19,-20},
    {25,28,26,20 },
    {11,18,20,25}
};

Console.WriteLine($"Задание 3.1 \nТемпераура на 2 метеостанции в течение 4 дня: {temperature[1, 3]} Градусов. \nНа 3 метеостанции: {temperature[2, 0]} Градусов ");

Console.WriteLine();

Console.WriteLine($"Задание 3.2 \nТемпература на всех станциях во второй день: ");
for (int i = 0, j = 1; i < temperature.GetLength(0); i++)
{
    Console.WriteLine($"В {i + 1} день {temperature[i, j]}");
}

Console.WriteLine("Задание 3.3");

Console.WriteLine("Температура воздуха в течение 4 дней");

for (int o = 0; o < days.Length; o++)
{
    Console.Write(days[o] + "\t");
}

Console.WriteLine();

for (int i = 0; i < temperature.GetLength(0); i++)
{
    for (int j = 0; j < temperature.GetLength(1); j++)
    {
        Console.Write(temperature[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine($"Задание 3.4");
double sum = 0;
for (int j = 0; j < 4; j++)
{
    sum = sum + temperature[2, j];
}
Console.WriteLine($"Средняя температура на третьей метеостанции: ({temperature[2, 0]} + {temperature[2, 1]} + {temperature[2, 2]} + {temperature[2, 3]}) / 4 = {sum / 4}");

Console.WriteLine();

Console.WriteLine("Задание 3.5 \nНомера станций и дни, где температура в диапазоне 24-26 градусов \n Станция 1 - нет данных \n Станция 2 - 1-й день и 3-й день \n Станция 3 - 4-й день ");

Console.WriteLine("Нажмите любую клавишу для выхода");
Console.ReadKey();
Console.Clear();