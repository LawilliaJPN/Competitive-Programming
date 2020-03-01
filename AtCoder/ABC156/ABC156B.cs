using System;

public class ABC156_B {
    private static void Main(string[] args) {
        var inputs = Console.ReadLine().Trim().Split();
        var n = int.Parse(inputs[0]);
        var k = int.Parse(inputs[1]);

        var logKN = Math.Log(n, k);
        var answer = (logKN == (int)logKN) ? ((int)logKN + 1) : Math.Ceiling(logKN);
        Console.WriteLine(answer);
    }
}
