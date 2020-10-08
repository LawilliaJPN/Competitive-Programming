using System;
using System.Collections.Generic;
using System.Linq;

public class ABC {
    private static void Main(string[] args) {
        var n = ReadInt();
        if (n < 3) { Console.WriteLine("0"); return; }
        var l = ReadIntsAsArrayAsc();

        var count = 0;
        for (var i = 0; i < n - 2; i++) {
            for (var j = i + 1; j < n - 1; j++) {
                for (var k = j + 1; k < n; k++) {
                    if ((l[i] + l[j] > l[k]) && (l[i] != l[j]) && (l[j] != l[k]) && (l[i] != l[k])) {
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }

    private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
    private static int[] ReadIntsAsArrayAsc() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
}