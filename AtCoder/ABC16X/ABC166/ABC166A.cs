// https://atcoder.jp/contests/abc166/tasks/abc166_a

using System;

public class ABC166A {
	private static void Main(string[] args) {
		var s = ReadStr();

		var answer = (s == "ABC") ? "ARC" : "ABC";
		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
}