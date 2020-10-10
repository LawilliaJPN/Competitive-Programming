using System;

public class ABC {
    private static void Main(string[] args) {
        var x = ReadBoolViaInt();
        var answer = Convert.ToInt32(!x);
        Console.WriteLine(answer);
    }

    private static bool ReadBoolViaInt() => Convert.ToBoolean(int.Parse(Console.ReadLine().Trim()));
}