// https://atcoder.jp/contests/abc162/tasks/abc162_c

using System;

public class ABC162C {
	private static void Main(string[] args) {
		var k = ReadInt();
		var answer = 0;

		for (int a = 1; a <= k; a++)
			for (int b = 1; b <= k; b++)
				for (int c = 1; c <= k; c++)
					answer += CalcGCD(a, b, c);

		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
	private static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
	private static int CalcGCD(int a, int b) => a > b ? GCD(a, b) : GCD(b, a);
	private static int CalcGCD(int a, int b, int c) => CalcGCD(CalcGCD(a, b), c);
}