Console.Clear();
Console.Write("Seminar_3 task_19\n\n");

Console.Write("input number: ");
string num = Console.ReadLine();

int right_index = num.Length - 1;
bool is_palin = true;
for (int i = 0; i < (num.Length / 2); i++) {
    if (num[i] != num[right_index]) {
        is_palin = false;
        break;
    }
    right_index -= 1;
}
if (is_palin) {
    Console.Write($"{num} -> palindrom");
}
else {
    Console.Write($"{num} -> not palindrom");
}