Console.Clear();
Console.WriteLine("Seminar_2 task_10\n");

int num = 0;
while (num < 100 | num > 999) {
    Console.Write("input 3 digit number: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"second digit -> {(num / 10) % 10}");