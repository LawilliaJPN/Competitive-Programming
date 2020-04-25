// https://atcoder.jp/contests/abc163/tasks/abc163_c

using System;
using System.Linq;

public class ABC163C {
	private static void Main(string[] args) {
		var n = ReadInt();
		var a = ReadIntsAsArray();
		var answers = new int[n];

		foreach (var i in a)
			answers[i-1]++;

		foreach (var answer in answers)
			Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}