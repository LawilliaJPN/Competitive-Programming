// https://atcoder.jp/contests/abc164/tasks/abc164_c

using System;
using System.Collections.Generic;

public class ABC164C {
	private static void Main(string[] args) {
		var n = ReadInt();
		var s = ReadStrLinesAsHashSet(n);

		var answer = s.Count;
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());

	private static HashSet<string> ReadStrLinesAsHashSet(int numOfLines) {
		var hs = new HashSet<string>();
		for (int i = 0; i < numOfLines; i++) hs.Add(Console.ReadLine().Trim());
		return hs;
	}
}