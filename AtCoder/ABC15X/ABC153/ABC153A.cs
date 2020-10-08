using System;

public class ABC153_A {
    private static void Main(string[] args) {
        var inputs = Console.ReadLine().Trim().Split();
        var h = double.Parse(inputs[0]);
        var a = double.Parse(inputs[1]);

        var answer = Math.Ceiling(h / a);
        Console.WriteLine(answer);
    }
}
