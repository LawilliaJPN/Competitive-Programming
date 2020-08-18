using System;

public class ABC {
	private static void Main(string[] args) {
		var s = ReadStr();

		var answer = (s == "RSR") ? 1 : (s.Length - s.Replace("R", "").Length);
		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
}