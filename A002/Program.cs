// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance (int x1, int y1,int z1,int x2,int y2,int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance; 
}

int GetNumber (string message)
{
    int userNumber;
    while (true)
    {
           Console.Write(message);
 
           if (int.TryParse(Console.ReadLine(), out int number))
           {
           userNumber = number;
           break;
           }
           else
           {
           Console.Write($"{number} не является числом, повторитье ввод.");
           }
    }
    return userNumber;
}



int x1Number = GetNumber("Вудите коордитату x1  -");
int y1Number = GetNumber("Вудите коордитату y1  -");
int z1Number = GetNumber("Вудите коордитату z1  -");
int x2Number = GetNumber("Вудите коордитату x2  -");
int y2Number = GetNumber("Вудите коордитату y2  -");
int z2Number = GetNumber("Вудите коордитату z2  -");


double myDistance = GetDistance(x1Number, y1Number, z1Number, x2Number, y2Number, z2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {y1Number}, {z1Number}) и ({x2Number}, {y2Number}, {z2Number}) составляет {Math.Round(myDistance, 2)}.");


