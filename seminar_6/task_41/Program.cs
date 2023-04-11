Console.Clear();
Console.Write("seminar_6 task_41\n\n");

Console.Write("input numbers through space:\n");
int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int count = 0;
foreach (int num in numbers){
    if (num > 0){
        count += 1;
    }
}
Console.Write($"-> {count}");