using System;
using System.Linq;

public class ABC158_B {
	private static void Main(string[] args) {
		var input = ReadLongsAsArray();
		var n = input[0];
		var a = input[1];
		var b = input[2];

		var quotient = n / (a + b);
		var remainder =  n % (a + b);

		var answer = quotient * a + Math.Min(a, remainder);
		Console.WriteLine(answer);
	}

	private static long[] ReadLongsAsArray() => Console.ReadLine().Trim().Split().Select(x => long.Parse(x)).ToArray();
}