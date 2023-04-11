Console.Clear();
Console.WriteLine("Seminar_1, task_8\n");

Console.Write("input positive number > 1: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1) {
    int even = 2;
    while (even <= num) {
        Console.Write($"{even} ");
        even += 2;
    }
}
else {
    Console.Write("invalid number");
}