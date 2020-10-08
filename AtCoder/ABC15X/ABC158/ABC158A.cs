using System;

public class ABC158_A {
    private static void Main(string[] args) {
        var s = ReadStr();

        var answer = ((s == "AAA") || (s == "BBB")) ? "Yes" : "No";
        Console.WriteLine(answer);
    }

    private static string ReadStr() => Console.ReadLine().Trim();
}