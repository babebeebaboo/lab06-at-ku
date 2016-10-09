/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: subaru.cs                         
//DATE: 6 Oct 2016                           
/////////////////////////////////////////////
using System;
class test
{
	static void Main()
	{
		Console.Write("How many times do Subaru die? ");
		int a = int.Parse(Console.ReadLine());
		Console.WriteLine("Witch Odor: {0:f2} WOU",wou(a));
		Console.WriteLine("Percentage difference: {0}%", per(wou(a)) );
	}
	static double wou(int a)
	{
		return 12.0*Math.Pow(1.2345,a);
	}
	static double per(double a)
	{
		double avr = (a+12)/2.0;
		return Math.Round(Math.Abs(a-12)/avr *100.0);
	}
}
