// https://atcoder.jp/contests/abc167/tasks/abc167_b

using System;
using System.Linq;

public class ABC167B {
	private static void Main(string[] args) {
		var inputs = ReadIntsAsArray();
		var a = inputs[0];
		var b = inputs[1];
		var c = inputs[2];
		var k = inputs[3];

		var answer = Math.Min(a, k) - Math.Min(c, Math.Max(0, k - a - b));
		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}