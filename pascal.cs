/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: pascal.cs                         
//DATE: 6 Oct 2016                           
/////////////////////////////////////////////
using System;
class MainClass {
 public static void Main(string[] args) {
  Console.Write("input : ");
  int a = int.Parse(Console.ReadLine());
  for (int i = 0; i < a; i++) {
   for (int j = 0; j <= i; j++) Console.Write("{0} ", ncr(i, j));
   Console.WriteLine();
  }

 }
 static int ncr(int i, int j) {
  return fac(i) / (fac(j) * fac(i - j));
 }
 static int fac(int i) {
  if (i == 0 || i == 1) return 1;
  else return i * fac(i - 1);
 }
}
