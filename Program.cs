// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowRange(int quad)
{
  if(quad ==1) Console.WriteLine("x > 0 and y > 0");
  else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
  else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
  else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
  else Console.WriteLine("Wrong number of quadrant!");
}

Console.Write("Input a number of quadrant: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

ShowRange(quadrant);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

int returnRes(double x, double y)
{
  if (x > 0 && y > 0) return 1;
  else if (x < 0 && y > 0) return 2;
  else if (x < 0 && y < 0) return 3;
  else if (x > 0 && y < 0) return 4;
}

Console.WriteLine("Enter coord x: ");
double coordX = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coord y: ");
double coordY = Convert.ToDouble(Console.ReadLine());

double returnRes = returnRes(coordX, coordY);
Console.WriteLine($"Ваша координатная плоскость {returnRes}");

/*
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N. (e.g. 1-1 2-4 3-9 4-16)

void TablKvad (int N)
{
    int count=1;
    while (count<=N)
    {
        Console.WriteLine ($"Квадрат числа {count}  составляет - { count*count} ");
        count++;
    }
}
Console.Write ("Введите значение  - ");
int num = Convert.ToInt32(Console.ReadLine()); 
TablKvad (num);
*/

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
/*
double Gipot (double x1, double y1, double x2, double y2)
{
  double distX = x2-x1;
  double distY = y2-y1;
  double result = Math.Sqrt(distX*distX + distY*distY);
  return result;
}
Console.Write ("Введите значение x1 - ");
int x1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение x2 - ");
int x2 = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine()); 

double rez = Math.Round(Gipot(x1,y1,x2,y2),4);
Console.Write ($"Расстояние между точками 1 и 2  составляет  - {rez}");
// Console.Write ($"Расстояние между точками 1 и 2  составляет  - {Gipot (x1,y1,x2,y2)}");
// double rez = Math.Round(Gipot(x1,y1,x2,y2),4);
*/

// https://github.com/lalerei/ProgrammingLangSem3.git