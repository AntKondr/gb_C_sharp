Console.Clear();
Console.WriteLine("seminar_9 task_66\n\n");

int summa(int min, int max){
    int res = min;
    if (min == max){
        return res;
    }
    else {
        res += summa(min + 1, max);
        return res;
    }
}


Console.Write("введите M и N через пробел: ");
int [] mn = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.Write(summa(mn[0], mn[1]));