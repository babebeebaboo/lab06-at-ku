/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: guideSign.cs                      
//DATE: 7 Oct 2016                           
/////////////////////////////////////////////
﻿using System;
class test
{
    static void Main()
    {
        Console.WriteLine("Welcome to Geek' GuideSign");
        Console.Write("Direction: ");
        string dir = Console.ReadLine();
        while (true)
        {
            if (dir.ToLower() == "up" ||
            dir.ToLower() == "down" ||
            dir.ToLower() == "left" ||
            dir.ToLower() == "right") break;
            Console.Write("Direction: ");
            dir = Console.ReadLine();
        }
        Console.Write("Distance: ");
        int dis;
        string aa = Console.ReadLine();
        while (true)
        {
            if (int.TryParse(aa, out dis))
                if (dis > 0)
                    break;
            Console.Write("Distance: ");
            aa = Console.ReadLine();
        }
        if (dir.ToLower() == "up") up(dis);
        if (dir.ToLower() == "down") down(dis);
        if (dir.ToLower() == "left") left(dis);
        if (dir.ToLower() == "right") right(dis);
    }
    static void up(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++) Console.Write(" ");
            for (int j = 0; j < 2 * i + 1; j++) Console.Write("*");
            Console.WriteLine();
        }

        for(int i = 0; i <= n; i++)
        {
            for (int j = 0; j < n ; j++) Console.Write(" ");
            Console.Write("*");
            Console.WriteLine();
        }
    }

    static void down(int n)
    {

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < n; j++) Console.Write(" ");
            Console.Write("*");
            Console.WriteLine();
        }

        for (int i = n; i >=0; i--)
        {
            for (int j = 0; j < n - i; j++) Console.Write(" ");
            for (int j = 0; j < 2 * i + 1; j++) Console.Write("*");
            Console.WriteLine();
        }

    }
    static void left(int n)
    {

        for (int i = n ; i > 0; i--)
        {
            for (int j = i; j > 0; j--) Console.Write(" ");
            for(int j = 0; j < n - i+1; j++) Console.Write("*");
            Console.WriteLine();
        }

        for (int i = 0; i < n * 2 + 2; i++) Console.Write("*");
        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j > 0; j--) Console.Write(" ");
            for (int j = 0; j < n - i + 1; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
    static void right(int n)
    {

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n + 1; j++)Console.Write(" ");
            for(int j = 0; j <= i; j++)Console.Write("*");
            Console.WriteLine();
        }

        for(int i=0;i<n*2+2;i++)Console.Write("*");
        Console.WriteLine();

        for (int i = n-1; i >=0; i--)
        {
            for (int j = 0; j < n + 1; j++)Console.Write(" ");
            for (int j = 0; j <= i; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}
