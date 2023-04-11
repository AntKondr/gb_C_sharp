Console.Clear();
Console.WriteLine("seminar_9 task_68\n\n");

int ack(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if (n == 0){
        return ack(m - 1, 1);
    }
    else {
        return ack(m - 1, ack(m, n - 1));
    }
}


Console.Write("введите M и N через пробел: ");
int [] mn = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write(ack(mn[0], mn[1]));