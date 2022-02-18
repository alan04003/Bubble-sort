using System;
using System.Diagnostics;
using System.Threading;


namespace bubble_sort
{
    class Program
    {
      static void Main(string[] args) {
      
      Stopwatch stop = Stopwatch.StartNew();
      stop.Start(); 

	
		Random rnd = new Random();
	   int[] arr = new int[5000];
      for (int j = 0; j < 5000; j++)
		   {
			   arr[j]=(rnd.Next(1, 5000)); 
		   }
	

         
         
         int temp;
            for (int j = 0; j <= arr.Length - 2; j++) {
               for (int i = 0; i <= arr.Length - 2; i++) {
                  if (arr[i] > arr[i + 1]) {
                     temp= arr[i + 1];
                     arr[i + 1] = arr[i];
                     arr[i] = temp;
                  }
               }
            }
         stop.Stop();
         
         Console.WriteLine("Sorted:");
         foreach (int p in arr)
         Console.Write(p + " ");
         Console.WriteLine(" ");  

         Console.WriteLine("Time = " + stop.ElapsedMilliseconds + " ms");
         Console.Read();
      }
   }
}

