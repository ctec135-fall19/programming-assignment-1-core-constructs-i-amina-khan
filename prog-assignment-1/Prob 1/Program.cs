/*
Author: Amina Khan
Date: 10/4/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 1

  Variables and Printing

1. Region 1: declare 3 double variables, each using a different syntax.
2. Region 2: declare and initialize separate variables for each CLS 
compliant type - print value of each variable
3. Region 3: print the min/max values for different types

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 variable declarations

            //3 ways to declare variables
            
            double myDouble1 = 0;

            System.Double myDouble2 = 0;

            double myDouble3 = new double();

            #endregion


            #region 2 variable initialization
            
            byte myByte = 50;
            short myShort = -1250;
            int myInt = 123456;
            long myLong = 12345678999;
            float myFloat = 123.45555F;
            double myDouble = 3.14;
            decimal myDecimal = 123456.123M;

            // c , used to format currency
            Console.WriteLine("myByte is: {0:c}", myByte);
            
            // exponential notation
            Console.WriteLine("myShort is: {0:E}", myShort);
            
            //hexadecimal formatting
            Console.WriteLine("myInt is: {0:x}", myInt);
            
            // exponential notation 
            Console.WriteLine("myLong is: {0:e}", myLong);
            
            // fixed-point formatting
            Console.WriteLine("myFloat is: {0:f3}", myFloat);
            
            // currency notation
            Console.WriteLine("myDouble is: {0:c}", myDouble);
            
            // basic numerical formatting with commas
            Console.WriteLine("myDecimal is: {0:n}", myDecimal);

            #endregion


            #region 3 Max/Min values

            // minimum and max value of byte
            Console.WriteLine("\nMinimum value of Byte: {0}", Byte.MinValue);
            Console.WriteLine("Maximum value of Byte: {0}", Byte.MaxValue);

            // minimum and max value of short
            Console.WriteLine("\nMinimum value of short: {0}", short.MinValue);
            Console.WriteLine("Maximum value of short: {0}", short.MaxValue);

            // minimum and max value of int
            Console.WriteLine("\nMinimum value of int: {0}", int.MinValue);
            Console.WriteLine("Maximum value of int: {0}", int.MaxValue);

            // minimum and max value of long
            Console.WriteLine("\nMinimum value of long: {0}", long.MinValue);
            Console.WriteLine("Maximum value of long: {0}", long.MaxValue);

            // minimum and max value of double
            Console.WriteLine("\nMinimum value of double: {0}", Double.MinValue);
            Console.WriteLine("Maximum value of double: {0}", Double.MaxValue);

            // minimum and max value of decimal
            Console.WriteLine("\nMinimum value of Decimal: {0}", Decimal.MinValue);
            Console.WriteLine("Maximum value of Decimal: {0}", Decimal.MaxValue);

            #endregion

        }
    }
}
