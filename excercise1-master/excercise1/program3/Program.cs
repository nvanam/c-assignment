using System;

namespace program3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input_string = Console.ReadLine ();
			char[] character_array = input_string.ToCharArray ();
			int vowelscount = 0;
			foreach (char i in character_array) {
				if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u') {
					vowelscount++;
				}
			}
			Console.WriteLine ("Number of vowels in {0} are {1}",input_string,vowelscount);
		}
	}
}
