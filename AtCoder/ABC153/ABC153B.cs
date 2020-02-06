using System;
using System.Linq;

public class ABC137_B {
    private static void Main(string[] args) {
        var inputs1 = Read1LineAsIntArray();
        var h = inputs1[0];
        var n = inputs1[1];
        var a = Read1LineAsIntArray();

        if (a.Sum() >= h)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
  
    private static int[] Read1LineAsIntArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}
