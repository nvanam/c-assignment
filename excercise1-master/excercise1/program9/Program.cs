using System;

namespace program10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			string[] arr = input.Split (' ');
			string temp=" ";
			int max = 0;
			foreach(string str in arr){
				if (str.Length > max) {
					max = str.Length;
					temp = str;
				}

			}
			Console.WriteLine ("max length word is {0} and its length is {1}",temp,max);
		}
	}
}
