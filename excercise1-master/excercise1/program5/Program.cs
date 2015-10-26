using System;

namespace program5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str = Console.ReadLine ();
			char[] arr = str.ToCharArray ();
			char char_to_search = Console.ReadKey().KeyChar;
			int result = 0;
			foreach (char i in arr) {
				if (i == char_to_search) {
					result++;
				}
			}
			Console.WriteLine (result);
		}
	}
}
