using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
        	int cheeck = 0;
        	while (cheeck == 0){
        	Console.WriteLine("Select the operation you want to perform, enter number: \n 1. Flip the number \n 2. Check how much time has passed since the beginning of the day \n 3. Find the number of squares in a rectangle \n 4. Find the sum and product of all digits of a number \n 5. Calculate the mean arephmeticm \n 6. To exit press enter ");
        	int numOperation = Convert.ToInt32(Console.ReadLine());
        	switch (numOperation)
			{
    			case 1:
        			Console.WriteLine("Please enter the number you want to flip:");
        			int n = Convert.ToInt32(Console.ReadLine());
        			Console.WriteLine(logik.Reverse(n));
        			break;
    			case 2:
        			Console.WriteLine(logik.TimePerDay());
        			break;
        		case 3:
        			Console.WriteLine("Enter a value for the side of the square:");
					int a = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter a value for the length of the rectangle:");
					int b = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Enter a value for the width of the rectangle:");
					int c = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(logik.NumOfSquaresInRectangle(a, b, c));
					break;
        		case 4:
        			Console.WriteLine("Enter the number the amount and the product of the digits you want to receive:");
        			int d = Convert.ToInt32(Console.ReadLine());
        			Console.WriteLine(logik.SumAndProductAllNum(d));
        			break;
        		case 5:
        			Console.WriteLine("Enter the number the arithmetic mean of which you want to get:");
        			int f = Convert.ToInt32(Console.ReadLine());
        			Console.WriteLine(logik.Average(f));
        			break;
    			default:
    				cheeck++;
        			Console.WriteLine("What");
        			break;
			}
		}
        	
        }
    }
}
