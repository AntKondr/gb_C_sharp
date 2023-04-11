Console.Clear();
Console.Write("Seminar_3 task_23\n\n");

Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int n = 1; n <= num; n++) {
    Console.Write($"{Math.Pow(n, 3)}, ");
}
Console.Write("\b\b ");