Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Неверный формат числа! Число должно быть пятизначным.");
    return;
}

int[] digits = new int[5];
int index = 1;

for (int i = 0; i <= 4; i++)
{
    digits[i] = number / index % 10;
    index *= 10;
}

if (digits[0] == digits[4] && digits[1] == digits[3])
    Console.WriteLine($"Число {number} - это полиндром!");
else
    Console.WriteLine($"Число {number} - это НЕ полиндром!");
