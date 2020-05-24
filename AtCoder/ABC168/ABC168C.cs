// https://atcoder.jp/contests/abc168/tasks/abc168_c

using System;
using System.Linq;

public class ABC168C {
	private static void Main(string[] args) {
		var inputs = ReadDoublesAsArray();
		var a = inputs[0];
		var b = inputs[1];
		var h = inputs[2];
		var m = inputs[3];

		var angle = ((h * 60 + m) * 360 / (12 * 60)) - (m * 360 / 60);
		var answer = CalcTriangleSide(a, b, CalcRadian(angle));
		Console.WriteLine(answer);
	}

	private static double[] ReadDoublesAsArray() => Console.ReadLine().Trim().Split().Select(x => double.Parse(x)).ToArray();
	private static double CalcRadian(double angle) => angle * Math.PI / 180;
	private static double CalcTriangleSide(double a, double b, double radian) => Math.Sqrt((a * a) + (b * b) - (2 * a * b * Math.Cos(radian)));
}