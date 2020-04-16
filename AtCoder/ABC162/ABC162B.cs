using System;

public class ABC162_B {
	private static void Main(string[] args) {
		var n = ReadInt();
		long answer = 0;

		for (int i = 1; i <= n; i++)
			if (i % 3 != 0 && i % 5 != 0)
				answer += i;

		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}