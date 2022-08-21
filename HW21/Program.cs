// Принять на вход координаты двух точек и найти расстояние между ними в 3D пространстве.


int Coordinate(string coorName, string positionName)
{
    Console.Write("Введите координату " + coorName + " точки: " + positionName);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");


int m = (x2 - x1);
int n = (y2 - y1);
int p = (z2 - z1);

double d = Math.Sqrt((Math.Pow(m,2)) + 
                (Math.Pow(n,2)) +  
                (Math.Pow(p,2)));

Console.WriteLine("Расстояние между точками равно: ");
Console.WriteLine(Math.Round(d, 2));
