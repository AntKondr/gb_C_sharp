Console.Clear();
Console.Write("seminar_6 task_add_2\n\n");

double input(string message=""){
    Console.Write(message);
    double data = Convert.ToDouble(Console.ReadLine());
    return data;
}


Console.Write("введите координаты вершин:\n");
Console.Write("вершина A:\n");
double x1 = input("x1 = ");
double y1 = input("y1 = ");

Console.Write("вершина B:\n");
double x2 = input("x2 = ");
double y2 = input("y2 = ");

Console.Write("вершина C:\n");
double x3 = input("x3 = ");
double y3 = input("y3 = ");

// считаем длины сторон AB BC CA
double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

double hp = (a + b + c) / 2;
double s = Math.Sqrt(hp * (hp - a) * (hp - b) * (hp - c));
Console.Write(Math.Round(s, 2));