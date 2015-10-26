using System;

namespace program12
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			string[] arr = input.Split (' ');
			foreach (string i in arr) {
				Console.Write (i.Length.ToString() + " ");
			}
		}
	}
}
