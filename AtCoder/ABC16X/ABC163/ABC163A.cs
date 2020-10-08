// https://atcoder.jp/contests/abc163/tasks/abc163_a

using System;

public class ABC163A {
	private static void Main(string[] args) {
		var r = ReadInt();

		var answer = r * 2 * Math.PI;
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}