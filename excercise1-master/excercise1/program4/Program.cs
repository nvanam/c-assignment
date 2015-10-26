using System;

namespace program4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input_string = Console.ReadLine ();
			string[] split_string = input_string.Split (' ');
			for(int i=0;i<split_string.Length;i++) {
				split_string[i] = split_string[i][0].ToString ().ToUpper() + split_string[i].Substring(1);
				Console.Write(split_string[i]+" ");
			}
		}
	}
}
