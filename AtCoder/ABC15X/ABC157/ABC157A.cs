using System;

public class ABC157_A {
    private static void Main(string[] args) {
        var n = Read1LineAsInt();
      
        var answer = (n / 2) + (n % 2);
        Console.WriteLine(answer);
    }

    private static int Read1LineAsInt() => int.Parse(Console.ReadLine().Trim());
}