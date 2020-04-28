// https://atcoder.jp/contests/abc164/tasks/abc164_d

using System;
using System.Linq;

public class ABC164D {
	private static void Main(string[] args) {
		var s = ReadIntDigitsAsArray();
		Array.Reverse(s);

		var divisor = 2019;
		var counters = new int[divisor];
		var dmod = 0;
		var tmod = 1;

		counters[0]++;
		foreach (var digit in s) {
			dmod = (tmod * digit + dmod) % divisor;
			tmod = (tmod * 10) % divisor;

			counters[dmod]++;
		}

		var answer = counters.Where(n => n >= 2).Select(n => CalcCombination(n, 2)).Sum();
		Console.WriteLine(answer);
	}

	private static int[] ReadIntDigitsAsArray() => Console.ReadLine().Trim().Select(c => c - '0').ToArray();

	private static int CalcCombination(int n, int k) {
		var temp = 1;
		for (var i = 1; i <= k; i++) {
			temp = temp * (n - i + 1) / i;
		}
		return temp;
	}
}