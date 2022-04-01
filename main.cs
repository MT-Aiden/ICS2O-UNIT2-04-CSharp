// Created by: Aiden McLeod
// Created on: Sep 2022
//
// This program finds area of a Triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the Base:");
        double Base =
Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Height:");
        double Height = Convert.ToDouble(Console.ReadLine());

        double Area = (Base * Height) / 2;
        Console.Write("Area of a Triangle = " + Area + "cm²");
        Console.ReadKey();
    }
}
