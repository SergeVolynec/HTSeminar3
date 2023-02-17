Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);

for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3) + "\t");
}