Console.Clear();
Console.Write("seminar_6 task_43\n\n");
Console.Write("Программа для поиска точки пересечения двух прямых вида y = kx + b\n\n");

Console.Write("Введите коэффициенты первой прямой:\n");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициенты второй прямой:\n");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2){
    Console.Write("прямые лежат одна на другой, точек пересечения бесконечно много");
}
else if (k1 == k2){
    Console.Write("прямые параллельны, точек пересечения нет");
}
else {
    double y = Math.Round((k2*b1 - k1*b2) / (k2 - k1), 2);
    double x = Math.Round((y - b1) / k1, 2);
    Console.Write($"точка пересечения ({x}, {y})");
}