using System;

public class ABC156_B {
    private static void Main(string[] args) {
        var inputs = Console.ReadLine().Trim().Split();
        var n = int.Parse(inputs[0]);
        var k = int.Parse(inputs[1]);

        var answer = Math.Floor(Math.Log(n, k) + 1);
        Console.WriteLine(answer);
    }
}