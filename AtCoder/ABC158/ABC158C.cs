using System;
using System.Linq;

public class ABC158_C {
	private static void Main(string[] args) {
		var input = ReadIntsAsArray();
		var a = input[0];
		var b = input[1];

		var minA = (int)Math.Ceiling(a * 12.5D);
		var maxA = (int)Math.Ceiling((a + 1) * 12.5D) - 1;
		var minB = b * 10;
		var maxB = (b + 1) * 10 - 1;

		var answer = -1;

		for (int i = minA; i <= maxA; i++) {
			if ((minB <= i) && (i <= maxB)) {
				answer = i;
				break;
			}
		}

		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}