// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int[] array = new int[6];
System.Console.WriteLine("Введите x1: ");
array[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y1: ");
array[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z1: ");
array[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите x2: ");
array[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите y2: ");
array[4] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите z2: ");
array[5] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Math.Sqrt(Math.Pow(array[3] - array[0], 2) + Math.Pow(array[4] - array[1], 2) + Math.Pow(array[5] - array[2], 2)));