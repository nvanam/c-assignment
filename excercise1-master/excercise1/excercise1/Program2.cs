using System;
using System.Collections.Generic;

namespace excercise1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> list_of_numbers = new List<int> ();
			list_of_numbers.Add (10);
			list_of_numbers.Add (20);
			list_of_numbers.Add (30);
			list_of_numbers.Add (40);

			float sum = 0;
			for (int i = 0; i < list_of_numbers.Count; i++) {
				sum += list_of_numbers [i];
			}
			Console.WriteLine (sum/4);
		}
	}
}
