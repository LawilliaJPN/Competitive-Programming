using System;
using System.Text;
using System.Linq;

public class ABC158_D {
	private static void Main(string[] args) {
		var s = ReadStr();
		var q = ReadInt();

		var isReversed = false;
		var sbHead = new StringBuilder("");
		var sbTail = new StringBuilder("");
		
		for (int i = 0; i < q; i++) {
			var query = ReadStrsAsArray();
			var t = query[0];

			if (t == "1") {
				isReversed = !isReversed;

			} else {
				var f = query[1];
				var c = query[2];

				if (IsHead(f, isReversed)) sbHead.Append(c);
				else sbTail.Append(c);
			}
		}

		var head = (isReversed) ? sbTail.ToString() : sbHead.ToString();
		head = new string(head.Reverse().ToArray());
		var tail = (isReversed) ? sbHead.ToString() : sbTail.ToString();
		if (isReversed) s = new string(s.Reverse().ToArray());

		var answer = head + s + tail;
		Console.WriteLine(answer);
	}

	private static string ReadStr() => Console.ReadLine().Trim();
	private static string[] ReadStrsAsArray() => Console.ReadLine().Trim().Split();
	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());
	private static bool IsHead(string f, bool isReversed) => (((f == "2") && (isReversed)) || ((f == "1") && (!isReversed)));
}