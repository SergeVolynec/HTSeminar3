Console.Write("Введите число: ");
string numberArray = Console.ReadLine();

if (int.TryParse(numberArray, out int isNumber) == false)
{
    Console.WriteLine("Некорректиный формат числа!");
    return;
}

int size = numberArray.Length;

//Если четное число знаков или один знак, число не имеет средней цифры, поэтому сразу прервемся
if (size % 2 == 0 || size == 1)
{
    Console.WriteLine("Число неинтересное!");
    return;
}

//Инициализируем max, min, среднюю цифру
int.TryParse(Convert.ToString(numberArray[0]), out int max);
int.TryParse(Convert.ToString(numberArray[0]), out int min);
int.TryParse(Convert.ToString(numberArray[size / 2]), out int middleDigit);

//Найдем max, min
for (int i = 1; i < size; i++)
{
    int.TryParse(Convert.ToString(numberArray[i]), out int digit);
    if (digit > max) max = digit;
    if (digit < min) min = digit;
}

if (max - min == middleDigit) Console.WriteLine("Число интересное!");
else Console.WriteLine("Число неинтересное!");