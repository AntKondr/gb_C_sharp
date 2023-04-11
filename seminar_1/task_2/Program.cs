Console.Clear();
Console.WriteLine("Seminar_1, task_2\n");

Console.Write("input number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.Write($"max -> {a}");
}
else if (b > a) {
    Console.Write($"max -> {b}");
}
else {
    Console.Write("numbers are equal");
}