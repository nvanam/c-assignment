using System;
using System.Collections.Generic;
namespace program7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> listofitems = new List<int> ();
			listofitems.Add (10);
			listofitems.Add (20);
			listofitems.Add (40);
			listofitems.Add (40);
			listofitems.Add (50);
			int[] freq = new int[listofitems.Count];
			for(int i=0;i<listofitems.Count;i++) {
				int temp = listofitems[i];
				int count = 0;
				foreach (int j in listofitems) {
					if (j == temp) {
						count++;
					}
				}
				freq [i] = count;
			}

			foreach(int i in freq){
				Console.WriteLine (i);
			}
		

		}
	}
}
