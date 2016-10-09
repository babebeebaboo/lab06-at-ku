/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: Mjolnir.cs                        
//DATE: 9 Oct 2016                           
/////////////////////////////////////////////
﻿
using System;
class test
{
    static void Main()
    {
        print(1, "Input Gold: ");
        double inp = double.Parse(Console.ReadLine());
        if ((int)(inp / 1000) == 0) print(1, "Not enough, Make More Merits Naja!!\n");
        else picture( (int)(inp / 1000) );
    }
    static void upordown(int inp)
    {
        print(1, " ");
        print(7 + (3 * (inp - 1)), "*");
    }
    static void print(int inp,string i)
    {
        for (int j = 0; j < inp; j++)
            Console.Write(i);
    }
    static void picture(int inp)
    {
        upordown(inp);
        print(1, "\n");
        for (int i = 0; i < 3 + (2 * (inp - 1)); i++)
        {
            print(9 + (3 * (inp - 1)), "*");
            print(1, "\n");
        }
        upordown(inp);
        print(1, "\n");
        for (int i = 0; i < 3 +inp-1; i++)
        {
            print(4 + inp - 1, " ");
            print(inp, "*");
            print(1, "\n");
        }
        for(int i = 0; i < inp; i++)
        {
            print(4 + inp - 2, " ");
            print(3 + inp - 1, "*");
            print(1, "\n");
        }
        print(4 + inp - 1, " ");
        print(inp, "*");
    }
}
