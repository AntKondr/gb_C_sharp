Console.Clear();
Console.WriteLine("Seminar_1, task_4\n");

Console.Write("input number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("input number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("input number c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a == b & b == c) {
    Console.Write($"numbers are equal\nmax -> {max}");
}
else {
    if (b > max) {
        max = b;
    }
    if (c > max) {
        max = c;
    }
    Console.Write($"max -> {max}");
}