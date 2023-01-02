// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите координаты первой точки по оси X: ");
double x1 =System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Y: ");
double y1 =System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты первой точки по оси Z: ");
double z1 =System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси X: ");
double x2 =System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Y: ");
double y2 =System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты второй точки по оси Z: ");
double z2 =System.Convert.ToDouble(Console.ReadLine());

double distance(double x1, double y1, double z1, double x2, double y2, double z2){
 double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
 result = Math.Round(result, 4);

 return result;
}

Console.WriteLine($"A({x1}; {y1}; {z1}); B({x2}; {y2}; {z2}) -> {distance(x1, y1, z1, x2, y2, z2)}");