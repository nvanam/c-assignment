using System;

namespace program13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine());
			Console.WriteLine(Math.Pow (((n * (n + 1)) / 2), 2));
		}
	}
}
