using System;

namespace program15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			char[] arr = input.ToCharArray ();
			for (int i = 0; i < arr.Length; i++) {
				if (i % 2 == 0) {
					Console.Write (arr [i]);
				} else {
					Console.Write (arr[i].ToString().ToUpper());
				}
			}

		}
	}
}
