using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution {
	static void Main(string[] args) {
		int N = int.Parse(Console.ReadLine());
		List<int> allHorses = new List<int>();
		for (int i = 0; i < N; i++) {
			int pi = int.Parse(Console.ReadLine());
			allHorses.Add(pi);
		}

		allHorses.Sort();
		int[] allHorsesArray = allHorses.ToArray();
		int difference = Math.Abs(allHorsesArray[0] - allHorsesArray[1]);
		for (int i = 1; i < N - 1; i++)	{
			int curDif = Math.Abs(allHorsesArray[i] - allHorsesArray[i + 1]);
			if (curDif < difference)
				difference = curDif;
		}

		Console.WriteLine(difference);
	}
}