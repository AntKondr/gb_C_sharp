Console.Clear();
Console.WriteLine("Seminar_2 task_13\n");

Console.Write("input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > -100 & num < 100) {
    Console.Write("третьей цифры нет");
}
else {
    int dig3 = 0;
    while (num / 100 != 0) {
        dig3 = num % 10;
        num = num / 10;
    }
    if (dig3 < 0) {
        dig3 = dig3 * (-1);
    }
    Console.Write($"третья цифра -> {dig3}");
}