using System;
using System.Collections.Generic;
using System.Linq;

public class ABC {
    private static void Main(string[] args) {
        var n = ReadInt();
        if (n < 3) { Console.WriteLine("0"); return; }
        var l = ReadIntsAsArrayAsc();
        Console.WriteLine(CountSuitableTriangle(0, 1, 2, 0, n, l));
    }

    private static int CountSuitableTriangle(int i, int j, int k, int count, int n, int[] l) {
        if ((l[i] + l[j] > l[k]) && (l[i] != l[j]) && (l[j] != l[k]) && (l[i] != l[k])) count++;
        if (k != n - 1) return CountSuitableTriangle(i, j, k + 1, count, n, l);
        else if (j != n - 2) return CountSuitableTriangle(i, j + 1, j + 2, count, n, l);
        else if (i != n - 3) return CountSuitableTriangle(i + 1, i + 2, i + 3, count, n, l);
        else return count;
    }

    private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
    private static int[] ReadIntsAsArrayAsc() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
}