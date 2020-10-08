// https://atcoder.jp/contests/abc162/tasks/abc162_d

using System;
using System.Collections.Generic;

public class ABC162D {
	private static void Main(string[] args) {
		var n = ReadInt();
		var s = ReadStr();

		var dict = new Dictionary<char, long>() {
			{'R', 0}, {'G', 0}, {'B', 0}
		};

		for (var i = 0; i < n; i++) 
			dict[s[i]]++;

		var answer = dict['R'] * dict['G'] * dict['B'];

		for (var i = 0; i <= n; i++) {
			for (var dif = 1; (i + dif + dif) < n ; dif++) {
				var j = i + dif;
				var k = j + dif;

				if ((s[i] != s[j]) && (s[i] != s[k]) && (s[j] != s[k]))
					answer--;
			}
		}

		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}