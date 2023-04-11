Console.Clear();
Console.WriteLine("Seminar_2 task_additional");
Console.WriteLine("сначала должны идти два числа отличных от 0\n");


Console.WriteLine("input numbers:");
int num1 = Convert.ToInt32(Console.ReadLine());
int max1 = num1;
int max2 = 0;

int num2 = Convert.ToInt32(Console.ReadLine());

// nums_count = 97 потому что ввели уже два числа из 100 и оставляем ещё одно на гарантированный ноль
// который в случае ввода 99 одинаковых чисел, обязан будет ввестись в 31 строке
int nums_count = 97;
if (num2 == num1) {
    while (num2 == num1 & nums_count != 0) {
        num2 = Convert.ToInt32(Console.ReadLine());
        nums_count -= 1;
    }
}

if (num2 > max1) {
    max2 = max1;
    max1 = num2;
}
else if (num2 < max1) {
    max2 = num2;
}

int num = Convert.ToInt32(Console.ReadLine());

// если получилось так, что мы ввели все 99 одинаковых чисел
// и в 31 строке ввели 0, то в этот цикл мы не попадём
// и max1 у нас равен этим числам, а max2 равен нулю, его мы и выводим в ответ стало быть
// т.к. по условию отрицательных чисел не должно быть
// но даже если бы и были, перед выводом мы легко могли бы сравнить между собой max1 и max2
// и вывести меньшее (ноль либо отрицательное число)
while (num != 0) {
    if (num > max1) {
        max2 = max1;
        max1 = num;
    }
    else if (num > max2 & num < max1) {
        max2 = num;
    }
    num = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"max2 -> {max2}");