// https://atcoder.jp/contests/abc164/tasks/abc164_b

using System;
using System.Linq;

public class ABC164B {
	private static void Main(string[] args) {
		var input = ReadDoublesAsArray();
		var a = input[0];
		var b = input[1];
		var c = input[2];
		var d = input[3];

		var answer = (Math.Ceiling(c / b) <= Math.Ceiling(a / d)) ? "Yes" : "No";
		Console.WriteLine(answer);
	}

	private static double[] ReadDoublesAsArray() => Console.ReadLine().Trim().Split().Select(x => double.Parse(x)).ToArray();
}