using System;

namespace program6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string string_input = Console.ReadLine ();
			string[] split_string = string_input.Split (' ');
			foreach(string i in split_string){
				char[] chrarr = i.ToCharArray ();
				Array.Reverse (chrarr);
				Console.Write(new String(chrarr) + " ");
				//Console.WriteLine (char.Parse('a'.ToString().ToUpper()));
			}
		}
	}
}
