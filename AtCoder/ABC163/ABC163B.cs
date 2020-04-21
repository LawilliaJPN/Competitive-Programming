// https://atcoder.jp/contests/abc163/tasks/abc163_b

using System;
using System.Linq;

public class ABC163B {
	private static void Main(string[] args) {
		var input = ReadIntsAsArray();
		var n = input[0];
		var a = ReadIntsAsArray();

		var answer = Math.Max(-1, n - a.Sum());
		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}