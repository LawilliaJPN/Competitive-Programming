using System;
using System.Linq;

public class ABC153_C {
    private static void Main(string[] args) {
        var k = Read1LineAsIntArray()[1];
        var h = Read1LineAsLongArray();

        var answer = h.OrderByDescending(x => x).Skip(k).Sum();
        Console.WriteLine(answer);
    }
  
    private static int[] Read1LineAsIntArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
    private static long[] Read1LineAsLongArray() => Console.ReadLine().Trim().Split().Select(x => long.Parse(x)).ToArray();
}
