﻿using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        // Input
        Console.Write("Enter your number in Dec format : ");
        long decNumber = long.Parse(Console.ReadLine());

        // Main Logic
        string hexNumber = "";
        while (decNumber != 0)
        {
            long remain = decNumber % 16;

            switch (remain)
            {
                case 10: hexNumber = "A" + hexNumber; break;
                case 11: hexNumber = "B" + hexNumber; break;
                case 12: hexNumber = "C" + hexNumber; break;
                case 13: hexNumber = "D" + hexNumber; break;
                case 14: hexNumber = "E" + hexNumber; break;
                case 15: hexNumber = "F" + hexNumber; break;
                default: hexNumber = remain + hexNumber; break;
            }
            decNumber /= 16;
        }
        Console.WriteLine("Your number in Hex format : {0}", hexNumber);
    }
}