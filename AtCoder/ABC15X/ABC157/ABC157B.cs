using System;
using System.Collections.Generic;
using System.Linq;

public class ABC157_B {
	private static void Main(string[] args) {
		var a = ReadIntsLinesAsList(3);
		var n = ReadInt();
		var b = ReadIntLinesAsList(n);

		var card = new BingoCard(a);
		b.ForEach((number) => card.Mark(number));

		var answer = (card.HasBingo()) ? "Yes" : "No";
		Console.WriteLine(answer);
	}

	private static int ReadInt() => int.Parse(Console.ReadLine().Trim());

	private static List<int> ReadIntLinesAsList(int numOfLines) {
		var list = new List<int>();
		for (int i = 0; i < numOfLines; i++)
			list.Add(int.Parse(Console.ReadLine().Trim()));
		return list;
	}
	  
	private static List<int> ReadIntsLinesAsList(int numOfLines) {
		var list = new List<int>();
		for (var i = 0; i < numOfLines; i++) {
			var tempArray = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
			for (var j = 0; j < tempArray.Length; j++)
				list.Add(tempArray[j]);
		}
		return list;
	}
}

public class Cell {
	private int number;
	private bool isMarked;

	public bool IsMarked {
		get { return this.isMarked; }
	}

	public Cell(int number) {
		this.number = number;
		this.isMarked = false;
	}

	public void Mark(int number) {
		if (number == this.number)
			isMarked = true;
	}
}

public class BingoCard {
	private List<Cell> cells = new List<Cell>();
	private int size;

	public BingoCard(List<int> numbers) {
		numbers.ForEach((n) => this.cells.Add(new Cell(n)));
		this.size = (int)Math.Sqrt(cells.Count());
	}

	public void Mark(int number) {
		cells.ForEach((x) => x.Mark(number));
	}

	public bool HasBingo() {
		if (HasVerticalBingo() || HasHorizontalBingo() || HasDiagonalBingo())
			return true;
		else
			return false;
	}

	private bool HasVerticalBingo() {
		for (int column = 0; column < size; column++) {
			bool isBingo = true;

			for (int row = 0; row < size; row++) {
				if (!cells[CalcIndex(row, column)].IsMarked)
					isBingo = false;
			}

			if (isBingo)
				return true;
		}
		return false;
	}

	private bool HasHorizontalBingo() {
		for (int row = 0; row < size; row++) {
			bool isBingo = true;

			for (int column = 0; column < size; column++) {
				if (!cells[CalcIndex(row, column)].IsMarked)
					isBingo = false;
			}

			if (isBingo)
				return true;
		}
		return false;
	}

	private bool HasDiagonalBingo() {
		if (HasSlashBingo() || HasBackslashBingo())
			return true;
		else
			return false;
	}

	private bool HasSlashBingo() {
		for (int row = 0; row < size; row++) {
			for (int column = 0; column < size; column++) {
				if ((row + column) == (size - 1)) {
					if (!cells[CalcIndex(row, column)].IsMarked) {
						return false;
					}
				}
			}
		}
		return true;
	}

	private bool HasBackslashBingo() {
		for (int row = 0; row < size; row++) {
			for (int column = 0; column < size; column++) {
				if (row == column) {
					if (!cells[CalcIndex(row, column)].IsMarked) {
						return false;
					}
				}
			}
		}
		return true;
	}

	public int CalcIndex(int row, int column) {
		return row * size + column;
	}
}