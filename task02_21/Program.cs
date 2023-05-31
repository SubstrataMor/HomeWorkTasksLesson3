// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Input()
{
    double spot = Convert.ToDouble(Console.ReadLine());
    return spot;
}
Console.WriteLine("Ведите координаты первой точки:");
double firstSpotX = Input();
double firstSpotY = Input();
double firstSpotZ = Input();
Console.WriteLine("Ведите координаты второй точки:");
double secondSpotX = Input();
double secondSpotY = Input();
double secondSpotZ = Input();

void Calculation(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) *(z2 - z1));
    Console.WriteLine(Math.Round(result, 2));
}
Console.Write("Расстояние между двух точек в пространстве = ");
Calculation(firstSpotX, firstSpotY, firstSpotZ, secondSpotX, secondSpotY, secondSpotZ);