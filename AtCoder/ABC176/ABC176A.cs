using System;
using System.Linq;

public class ABC {
    private static void Main(string[] args) {
        var input = ReadIntsAsArray();
        var n = input[0];
        var x = input[1];
        var t = input[2];

        var answer = (n + x - 1) / x * t;
        Console.WriteLine(answer);
    }

    private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}