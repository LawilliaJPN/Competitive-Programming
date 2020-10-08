// https://atcoder.jp/contests/abc168/tasks/abc168_a

using System;

public class ABC168A {
	private static void Main(string[] args) {
		var n = ReadInt();
		var reading = new string[] {
			"pon", "pon", "hon", "bon", "hon",
			"hon", "pon", "hon", "pon", "hon",
		};

		var answer = reading[n % 10];
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}