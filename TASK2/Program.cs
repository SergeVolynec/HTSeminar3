Console.WriteLine("Введите координату A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.Write("Расстояние между точками: " + Math.Round(result, 2));