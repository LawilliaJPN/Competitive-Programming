using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class ABC157_C {
	private static void Main(string[] args) {
		var input = ReadIntsAsArray();
		var n = input[0];
		var m = input[1];

		var number = new Number(n);
		for (int i = 0; i < m; i++) {
			input = ReadIntsAsArray();
			number.Guess(input[0], input[1]);
		}

		var answer = number.GetAnswer();
		Console.WriteLine(answer);
	}

	private static int[] ReadIntsAsArray() => Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
}

public class Digit {
	private int number;
	private int initialNumber;
	private bool isGuessed;
	private bool canGuess;

	public int Number {
		get { return this.number; }
	}

	public bool CanGuess {
		get { return this.canGuess; }
	}

	public Digit(int number) {
		this.number = this.initialNumber = number;
		this.isGuessed = false;
		this.canGuess = true;
	}

	public void Guess(int number) {
		if ((isGuessed) && (this.number != number)) {
			this.canGuess = false;

		} else if (number < this.initialNumber) {
			this.canGuess = false;

		} else {
			this.number = number;
			this.isGuessed = true;
		}
	}
}

public class Number {
	private List<Digit> digits = new List<Digit>();

	public Number(int digit) {
		if (digit == 1) {
			this.digits.Add(new Digit(0));

		} else {
			this.digits.Add(new Digit(1));

			for (int i = 0; i < (digit - 1); i++) {
				this.digits.Add(new Digit(0));
			}
		}
	}

	public void Guess(int s, int c) {
		this.digits[s-1].Guess(c);
	}

	public string GetAnswer() {
		StringBuilder sb = new StringBuilder("");

		foreach (var digit in digits) {
			if (!digit.CanGuess) return "-1";
			else sb.Append(digit.Number);
		}

		return sb.ToString();
	}
}