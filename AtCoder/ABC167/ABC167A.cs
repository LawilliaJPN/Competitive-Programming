// https://atcoder.jp/contests/abc167/tasks/abc167_a

using System;

public class ABC167A {
	private static void Main(string[] args) {
		var s = ReadStr();
		var t = ReadStr();

		var answer = (s == ExcludeTail(t)) ? "Yes" : "No";
		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
	private static string ExcludeTail(string str) => str.Substring(0, str.Length - 1);
}