/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: mathContest.cs                    
//DATE: 6 Oct 2016                           
/////////////////////////////////////////////
using System;
using System.Collections.Generic;
class test {

 static bool isPrime(int a) {
  if (a == 1) return false;
  if (a == 2) return true;
  for (int i = 3; i < a; i++)
   if (a % i == 0) return false;
  return true;
 }
 static void Main() {
  Console.Write("numbers of competitors: ");
  int n = int.Parse(Console.ReadLine());
  string[] name = new string[n];
  int[] score = new int[n];
  for (int i = 0; i < n; i++) name[i] = Console.ReadLine();
  /*
  How To use Dictionary
  Dictionary<int, bool> some = new Dictionary<int, bool>();

  some.Add(key,true);
  some.ContainsKey(key);
  */
  int o = 0;
  int round = 0;
  string aa = Console.ReadLine();
  int tmp;
  int inp;
  bool[] some = new bool[1000000];
  while (int.TryParse(aa, out inp) == false){
	aa = Console.ReadLine();
  }
  if (some[inp] == false) {
   some[inp]=true;
   if (isPrime(inp)) {
    if (inp % 10 == 1) score[o]++;
    if (inp % 10 == 3) score[o] += 2;
    if (inp % 10 == 5) score[o] += 3;
    if (inp % 10 == 7) score[o] += 4;
    if (inp % 10 == 9) score[o]--;
   }
   o++;
  }
  while (true) {
   aa = Console.ReadLine();
   while (int.TryParse(aa, out inp) == false ) {
    aa = Console.ReadLine();
   }

   if (isPrime(inp)) {
    if (inp % 10 == 1) score[o]++;
    if (inp % 10 == 3) score[o] += 2;
    if (inp % 10 == 5) score[o] += 3;
    if (inp % 10 == 7) score[o] += 4;
    if (inp % 10 == 9) score[o]--;
   }
   o++;
   if (o == n) {
    o = 0;
    round++;
   }
   if(inp<0){}
   else if (!some[inp]) {
    some[inp]=true;
   } else if (some[inp]) {
    o++;
    if (o == n) {
     o = 0;
     round++;
    }
    break;
   }
  }
  Console.WriteLine("{0} round(s)", round);
  Console.WriteLine("score name");
  for (int i = 0; i < n; i++) Console.WriteLine("{0} {1}", score[i], name[i]);
 }
}
