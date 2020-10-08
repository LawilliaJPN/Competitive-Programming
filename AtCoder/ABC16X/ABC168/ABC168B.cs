// https://atcoder.jp/contests/abc168/tasks/abc168_b

using System;

public class ABC168B {
	private static void Main(string[] args) {
		var k = ReadInt();
		var s = ReadStr();

		var answer = (s.Length > k) ? (s.Substring(0, k) + "...") : s;
		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}