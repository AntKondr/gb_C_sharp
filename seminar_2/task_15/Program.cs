Console.Clear();
Console.WriteLine("Seminar_2 task_15\n");

int num = 0;
while (num <= 0) {
    Console.Write("input positive number of week's day: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int offset = num / 7;

if ((num - offset) % 6 == 0 | num % 7 == 0) {
    Console.Write("it's a weekend!!!");
}
else {
    Console.Write("it's a workday :(");
}