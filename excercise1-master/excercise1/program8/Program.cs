using System;

namespace program8
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			int[] numbers = new int[100000];


			for(int i=0;i<100000;i++){
				numbers[i]=0;
			}
			for(int i=2;i<=(int)Math.Sqrt(100000)+1;i++){
				if(numbers[i]==0){
					int j=i,k=2;
					while(j*k<100000){
						numbers[j*k]=1;
						k++;
					}


				}

			}
			int n = int.Parse (Console.ReadLine());

			if (numbers [n] == 0) {
				Console.WriteLine ("Yes it is a prime");
			} else {
				Console.WriteLine (" No it is not a prime");
			}


		}
	}
}
