using System;

public class ABC162_A {
	private static void Main(string[] args) {
		var n = ReadInt();

		var answer = (n / 100 == 7 || n / 10 % 10 == 7 || n % 10 == 7) ? "Yes" : "No";
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}