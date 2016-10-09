/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: pobyTable.cs                      
//DATE: 6 Oct 2016                           
/////////////////////////////////////////////
using System;
class test{
   static void Main()
   {
      Console.Write("Table width: ");
      double w = double.Parse(Console.ReadLine());
      Console.Write("Table length: ");
      double l = double.Parse(Console.ReadLine());
      Console.Write("Type of thing: ");
      string t = Console.ReadLine();
      double rad=0;
      double area=w*l;
      int nothing=0;

      while(t!="eraser" || t!="book" || t != "ruler"){
         if(t == "eraser"){
            Console.Write("eraser's radius: ");
            rad = double.Parse(Console.ReadLine());
            rad = Math.PI*rad*rad;
            break;
         }
         else if(t=="book"){
            Console.Write("book's radius: ");
            rad = double.Parse(Console.ReadLine());
            rad = rad*rad;
            break;
         }
         else if(t == "ruler"){
            Console.Write("ruler's length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("ruler's height: ");
            double hei = double.Parse(Console.ReadLine());
            rad = len*hei/2.0;
         }
      }

      while(rad < area){
      	Console.WriteLine("DEBUGG");
      	if(t=="eraser" || t=="book" || t == "ruler"){nothing++;area-=rad;}
      	rad=0;
         Console.Write("Type of thing: ");
         t = Console.ReadLine();
         if(t == "eraser"){
            Console.Write("eraser's radius: ");
            rad = double.Parse(Console.ReadLine());
            rad = Math.PI*rad*rad;
         }
         else if(t=="book"){
            Console.Write("book's radius: ");
            rad = double.Parse(Console.ReadLine());
            rad = rad*rad;
         }
         else if(t == "ruler"){
            Console.Write("ruler's length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("ruler's height: ");
            double hei = double.Parse(Console.ReadLine());
            rad = len*hei/2.0;
         }

      }
      Console.WriteLine("Number of thing(s):{0}",nothing);
      Console.WriteLine("{0} space left",area);

   }
}
