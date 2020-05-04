// https://atcoder.jp/contests/abc166/tasks/abc166_b

using System;
using System.Collections.Generic;
using System.Linq;

public class ABC166B {
	private static void Main(string[] args) {
		var inputs = ReadIntsAsArray();
		var n = inputs[0];
		var k = inputs[1];
		var isTrickArray = Enumerable.Repeat(true, n).ToArray();

		for (var i = 0; i < k; i++) {
			var d = ReadInt();
			ReadIntsAsList().ForEach(x => isTrickArray[x-1] = false);
		}

		var answer = isTrickArray.Count(isTrick => isTrick);
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
	private static List<int> ReadIntsAsList() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToList();
}