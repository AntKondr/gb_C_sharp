Console.Clear();
Console.Write("Seminar_3 task_21\n\n");

Console.Write("input point Ax: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.Write("input point Ay: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.Write("input point Az: ");
double az = Convert.ToDouble(Console.ReadLine());
Console.Write("\n");

Console.Write("input point Bx: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.Write("input point By: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.Write("input point Bz: ");
double bz = Convert.ToDouble(Console.ReadLine());

double l = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
Console.Write($"l = {Math.Round(l, 2)}");