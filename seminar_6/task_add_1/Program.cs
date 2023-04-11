Console.Clear();
Console.Write("seminar_6 task_add_1\n");
Console.Write("permutations\n\n");

void perm(char[] arr, int n){
    if (n < 2){
        Console.Write($"{string.Join("", arr)}\n");
    }
    else {
        for (int j = n - 1; j >= 0; j--){
            char temp = arr[j];
            arr[j] = arr[n - 1];
            arr[n - 1] = temp;
            perm(arr, n - 1);
            temp = arr[j];
            arr[j] = arr[n - 1];
            arr[n - 1] = temp;
        }
    }
}

Console.Write("input string:\n");
char[] ch_arr = Console.ReadLine().ToCharArray();
Console.Write("\n");

perm(ch_arr, ch_arr.Length);