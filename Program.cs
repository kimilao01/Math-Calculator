using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Math_Calculator_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Calculator v1.2.3";
            Console.SetWindowSize(120, 30);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***** Math Calculator v1.2.3 *****");
            Console.WriteLine("-Enter \"help\" for help");
            Console.WriteLine("-Enter \"info\" for more information");
            Console.WriteLine("-Enter \"copyright\" for copyright license");
            Console.WriteLine("-Enter \"clear\" to clear the screen");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

            bool rerun = false;

            while (true)
            {
                while (!rerun)
                {
                    Console.WriteLine("");
                    string input = Console.ReadLine();//waiting for input
                    if (input == "help")//ask for help
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine("********************************");
                        Console.WriteLine("Only Non-Negative Numbers");
                        Console.WriteLine("Only two numbers");
                        Console.WriteLine("");
                        Console.WriteLine("Operators:");
                        Console.WriteLine("Addition: +");
                        Console.WriteLine("Subtraction: -");
                        Console.WriteLine("Multiplication: *");
                        Console.WriteLine("Division: /");
                        Console.WriteLine("Power: ^");
                        Console.WriteLine("");
                        Console.WriteLine("Input Format:");
                        Console.WriteLine("1+1");
                        Console.WriteLine("");
                        Console.WriteLine("-Enter \"help\" for help");
                        Console.WriteLine("-Enter \"info\" for more information");
                        Console.WriteLine("-Enter \"copyright\" for copyright license");
                        Console.WriteLine("-Enter \"clear\" to clear the screen");
                        Console.WriteLine("********************************");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    if (input == "info")//ask for more infomations
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine("********************************");
                        Console.WriteLine("Version 1.2.3");
                        Console.WriteLine("Programed in C#");
                        Console.WriteLine("100% by Kimi Lao");
                        Console.WriteLine("Published in 2020/12/10");
                        Console.WriteLine("Any problem please contact:");
                        Console.WriteLine("kimilao0124@gmail.com");
                        Console.WriteLine("********************************");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    if (input == "copyright")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("********************************");
                        Console.WriteLine("Copyright © 2020 by Kimi Lao");
                        Console.WriteLine("All rights reserved. This Program or any portion thereof");
                        Console.WriteLine("may not be reproduced or used in any manner whatsoever");
                        Console.WriteLine("without the express written permission of the publisher");
                        Console.WriteLine("except for the use of brief quotations in a program review.");
                        Console.WriteLine("");
                        Console.WriteLine("Programed in Macao, China");
                        Console.WriteLine("********************************");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    if (input == "clear")
                    {
                        Console.Clear();
                        rerun = true;
                        break;
                    }
                    foreach (char c in input)//check for error(s)
                    {
                        if (c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != '0' && c != '+' && c != '-' && c != '*' && c != '/' && c != '.' && c != '^')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please enter numbers and operators.");
                            Console.ForegroundColor = ConsoleColor.White;
                            rerun = true;
                            break;
                        }
                    }
                    if (input.Contains("+") == false)
                    {
                        if (input.Contains("-") == false)
                        {
                            if (input.Contains("*") == false)
                            {
                                if (input.Contains("/") == false)
                                {
                                    if (input.Contains("^") == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Please enter an operator.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        rerun = true;
                                        break;
                                    }
                                }
                            }

                        }

                    }
                    string a = "", b = "", symbol = "";
                    int stage = 0;
                    foreach (char c in input)//stage 0: a value//stage 1: symbol//stage 2: b value
                    {
                        if (stage == 0)//stage 0
                        {
                            if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '0' || c == '.')
                            {
                                a += Convert.ToString(c);
                            }
                            else if (a == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the first number properly.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                            else
                            {
                                stage = 1;
                            }
                        }
                        if (stage == 2)//stage 2
                        {
                            if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '0' || c == '.')
                            {
                                b += Convert.ToString(c);
                            }
                            else if (b == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the second number properly.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the second number properly.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                        }
                        if (stage == 1)//stage 1
                        {
                            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^')
                            {
                                symbol += Convert.ToString(c);
                                stage = 2;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the operator properly.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                        }
                    }
                    if (a == "" || a == ".")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter the first number properly.");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    if (b == "" || b == ".")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter the second number properly.");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    if (symbol == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No operators.");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    int aDecimalPoints = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == '.')
                        {
                            aDecimalPoints++;
                        }
                    }
                    if (aDecimalPoints > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No more than two decimal points in a number.");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    int bDecimalPoints = 0;
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] == '.')
                        {
                            bDecimalPoints++;
                        }
                    }
                    if (bDecimalPoints > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No more than two decimal points in a number.");
                        Console.ForegroundColor = ConsoleColor.White;
                        rerun = true;
                        break;
                    }
                    double ans = 0;
                    switch (symbol)
                    {
                        case "+":
                            ans = Convert.ToDouble(a) + Convert.ToDouble(b);
                            Console.WriteLine(ans);
                            break;
                        case "-":
                            ans = Convert.ToDouble(a) - Convert.ToDouble(b);
                            Console.WriteLine(ans);
                            break;
                        case "*":
                            ans = Convert.ToDouble(a) * Convert.ToDouble(b);
                            Console.WriteLine(ans);
                            break;
                        case "/":
                            if (b == "0")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No division by 0.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                            ans = Convert.ToDouble(a) / Convert.ToDouble(b);
                            Console.WriteLine(ans);
                            break;
                        case "^":
                            if (a == "0" && b == "0")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No 0 powered by 0.");
                                Console.ForegroundColor = ConsoleColor.White;
                                rerun = true;
                                break;
                            }
                            ans = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b));
                            Console.WriteLine(ans);
                            break;
                    }
                }
                rerun = false;
            }
        }
    }
}
