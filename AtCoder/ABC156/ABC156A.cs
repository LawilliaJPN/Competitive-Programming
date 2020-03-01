using System;

public class ABC156_A {
    private static void Main(string[] args) {
        var inputs = Console.ReadLine().Trim().Split();
        var n = int.Parse(inputs[0]);
        var r = int.Parse(inputs[1]);

        var answer = r + Math.Max(0, 100 * (10-n));
        Console.WriteLine(answer);
    }
}