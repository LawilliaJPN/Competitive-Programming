using System;

public class ABC {
    private static void Main(string[] args) {
        var s = ReadStr();

        var answer = s.EndsWith("s") ? (s + "es") : (s + "s");
        Console.WriteLine(answer);
    }

    private static string ReadStr() => Console.ReadLine().Trim();
}