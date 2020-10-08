using System;
using System.Linq;

public class ABC {
    private static void Main(string[] args) {
        var input = ReadDoublesAsArray();
        var d = input[0];
        var t = input[1];
        var s = input[2];

        var answer = (d / s <= t) ? "Yes" : "No";
        Console.WriteLine(answer);
    }

    private static double[] ReadDoublesAsArray() => Console.ReadLine().Trim().Split().Select(x => double.Parse(x)).ToArray();
}