Console.Write("Введите сумму вклада число: ");
int sum = Convert.ToInt32(Console.ReadLine());

if (sum < 0)
{
    Console.WriteLine("Неверный формат числа! Число должно быть положительным.");
    return;
}

double result = 0;
if (sum < 100) result = sum + sum * 0.05;
else if (sum >= 100 && sum <= 200) result = sum + sum * 0.07;
else result = sum + sum * 0.1;

Console.Write("Сумма с процентами равна: " + result);