using System;

namespace program14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			string[] arr = input.Split (' ');
			string temp=" ";
			int min = 1000;
			foreach(string str in arr){
				if (str.Length < min) {
					min = str.Length;
					temp = str;
				}

			}
			Console.WriteLine ("min length word is {0} and its length is {1}",temp,min);
		}
	}
}
