// https://atcoder.jp/contests/abc166/tasks/abc166_c

using System;
using System.Linq;

public class ABC166C {
	private static void Main(string[] args) {
		var inputs = ReadIntsAsArray();
		var n = inputs[0];
		var m = inputs[1];
		var h = ReadIntsAsArray();
		var isPeakArray = Enumerable.Repeat(true, n).ToArray();

		for (var i = 0; i < m; i++) {
			inputs = ReadIntsAsArray();
			var a = inputs[0];
			var b = inputs[1];

			if (h[a-1] <= h[b-1]) isPeakArray[a-1] = false;
			if (h[b-1] <= h[a-1]) isPeakArray[b-1] = false;
		}

		var answer = isPeakArray.Count(isPeak => isPeak);
		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}