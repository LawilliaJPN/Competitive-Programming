using System;
using System.Linq;

public class ABC153_B {
    private static void Main(string[] args) {
        var h = Read1LineAsIntArray()[0];
        var a = Read1LineAsIntArray();

        var answer = (a.Sum() >= h) ? "Yes" : "No";
        Console.WriteLine(answer);
    }
  
    private static int[] Read1LineAsIntArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}
