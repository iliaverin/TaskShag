using System;

namespace App
{
	class logik{
		public static string Reverse(int a){
			string s = a.ToString();
			char[] ar = s.ToCharArray();
			Array.Reverse(ar);
			s = new String(ar);
			a = Convert.ToInt32(s);

			return $"Inverted number: {a}";
		}
		public static string TimePerDay(){
			int currentTimeHour = Convert.ToInt32((DateTime.Now.ToString("HH")));
			int currentTimeMinutes = Convert.ToInt32((DateTime.Now.ToString("mm")));
			int currentTimeSeconds = Convert.ToInt32((DateTime.Now.ToString("ss")));
			double rezultInSecond = (currentTimeHour * 60 * 60) + (currentTimeMinutes * 60) + currentTimeSeconds;
			double rezultInMinutes = (currentTimeHour * 60) + currentTimeMinutes + (currentTimeSeconds/60);
			double rezultInHour = currentTimeHour + (currentTimeMinutes/60) + (currentTimeSeconds/60/60);
			string allRez = ($" Elapsed time in second: {rezultInSecond} \n Elapsed time in minutes: {rezultInMinutes} \n Elapsed time in hour: {rezultInHour} \n");

			return allRez;
		}
		public static string NumOfSquaresInRectangle(int a, int b, int c){
			double SquareArea = Math.Pow(a, 2);
			double SquareRectangle = b * c;
			int NumOfSquaresInRectangle = 0;
			while (SquareRectangle>0){
				SquareRectangle -= SquareArea;
				NumOfSquaresInRectangle++;
			}
			if((SquareRectangle+=SquareArea) == 0)
			{
				SquareRectangle = 0;
			}else{
				NumOfSquaresInRectangle--;
			}
			string rez = ($" Number Of Squares In Rectangle: {NumOfSquaresInRectangle} \n Remaining area: {SquareRectangle} \n");
			return rez;
		}
		public static string SumAndProductAllNum(int d){
			int sum = 0;
			int product = 1;
			while (d>0){
				int remainderOfTheDivision = d % 10;
				sum += remainderOfTheDivision;
				product *= remainderOfTheDivision;
				d = d / 10;
			}
			string a = ($" Sum of all digits of the number: {sum} \n Product of all digits of a number: {product}\n");
			return a;
		}
		public static string Average(int f){
			int average = 0;
			int sum = 0;
			int i = 0;
			while (f>0){
				i++;
				int remainderOfTheDivision = f % 10;
				sum += remainderOfTheDivision;
				f = f / 10;
			}
			average = sum / i; 
			string a = ($" The arithmetic mean is: {average} \n ");
			return a;
			
		}
	}
    
}
