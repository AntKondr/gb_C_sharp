Console.Clear();
Console.Write("Seminar_3 task_additional\n\n");

Console.Write("input bushes amount: ");
int bushes = Convert.ToInt32(Console.ReadLine());
while (bushes < 3 | bushes > 1000) {
    Console.Write("input correct bushes amount: ");
    bushes = Convert.ToInt32(Console.ReadLine());
}

int[] berrys = new int[bushes];

Console.Write("input berrys amount on bushes:\n");
for (int i = 0; i < berrys.Length; i++) {
    int berry_amount = Convert.ToInt32(Console.ReadLine());
    berrys[i] = berry_amount;
}

int max_harvest = berrys[0] + berrys[1] + berrys[berrys.Length - 1];
int best_pos = 0;

if (berrys[0] + berrys[berrys.Length - 1] + berrys[berrys.Length - 2] > max_harvest) {
    max_harvest = berrys[0] + berrys[berrys.Length - 1] + berrys[berrys.Length - 2];
    best_pos = berrys.Length - 1;
}
for (int i = 2; i < berrys.Length; i++) {
    if (berrys[i-2] + berrys[i-1] + berrys[i] > max_harvest) {
        max_harvest = berrys[i-2] + berrys[i-1] + berrys[i];
        best_pos = i - 1;
    }
}
Console.Write($"max_harvest -> {max_harvest}  on {best_pos + 1} bush");