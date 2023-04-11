Console.Clear();
Console.WriteLine("Seminar_1, task_6\n");

Console.Write("input number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 0 | a < 0) {
    if (a % 2 == 0) {
        Console.Write($"{a} -> is even number");
    }
    else {
        Console.Write($"{a} -> is odd number");
    }
}
else {
    Console.Write("you input a zero!");
}