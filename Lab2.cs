/*
 * Written by: Nicholas Cockcroft
 * Date: January 25, 2018
 * Class: .NET Environment
 * Assignment: Lab 2
 * 
 * Description: Output the root of the equation y = x^3 - 2 using the half interval
 * method.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Lab2
    {
        static void Main(string[] args)
        {
            // Variables
            double num1 = 1;
            double num2 = 2;
            double resultFromBi = 0;
            double result = 0;

            for(int i = 0; i < 21; i++)
            {
                // Performing the bijection.
                resultFromBi = (num1 + num2) / 2.0;

                // Plugging 1 into the original function.
                result = Math.Pow(resultFromBi, 3) - 2;

                // If the result is less than zero, we need to set the result equal to num1
                // and keep num2 to what it was.
                if(result < 0)
                {
                    num1 = resultFromBi;
                }
                // If the result is greater than zero, we need to set the result equal to num2
                // and keep num1 what it was.
                else if(result > 0)
                {
                    num2 = resultFromBi;
                }
                
            }

            Console.Write("Result from half interval method: {0}\n", resultFromBi);

            Console.Write("The cube root of 2 is: {0} \n", Math.Pow(2, (1.0 / 3.0) ));
        }
    }
}
