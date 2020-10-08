using System;

public class ABC {
	private static void Main(string[] args) {
		var x = ReadInt();

		var answer = (x >= 30) ? "Yes" : "No";
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
}