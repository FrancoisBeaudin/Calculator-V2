// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

/* 
 Premier projet solo dans lequel je tente de créer une calculatrice avec le plus de connaissances possible, Classes, Methods, Constructors, Switch, User Input, If Statements et possiblement une loop.
 */
namespace CalculatorV2
{
    class Program
    {
        class Calculator
        {
            public double num1;
            public double num2;


            public void Plus()
            {
                double result = num1 + num2;
                Console.WriteLine("______________________________");
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
                Console.WriteLine("______________________________");
            }
            public void Minus()
            {
                double result = num1 - num2;
                Console.WriteLine("______________________________");
                Console.WriteLine(num1 + " - " + num2 + " = " + result);
                Console.WriteLine("______________________________");
            }
            public void Times()
            {
                double result = num1 * num2;
                Console.WriteLine("______________________________");
                Console.WriteLine(num1 + " * " + num2 + " = " + result);
                Console.WriteLine("______________________________");
            }
            public void By()
            {
                double result = num1 / num2;
                Console.WriteLine("______________________________");
                Console.WriteLine(num1 + " / " + num2 + " = " + result);
                Console.WriteLine("______________________________");
            }
          
        }





        static void Main()
        {
            
                bool boot = false;
                Console.WriteLine("Do you want to start the program? enter Y/N ");
                string bootAnswer = Console.ReadLine();
                bootAnswer.ToUpper();
                if (bootAnswer == "Y")
                {
                    boot = true;
                }
                else if (bootAnswer == "N")
                {
                    boot = false;
                }
                else
                {
                    Console.WriteLine("You must enter your answer with Y or N");
                }

            

            while (boot == true)  
                {
                    Console.WriteLine("Welcome to Calculabot 21337");
                    Console.WriteLine("Please select your operator with it's assigned Number to begin a calculus.");
                    Console.WriteLine("1 - Additions");
                    Console.WriteLine("2 - Substractions");
                    Console.WriteLine("3 - Multiplications");
                    Console.WriteLine("4 - Divisions");
                    string calcSelect = Console.ReadLine();
                    int calcInput = Convert.ToInt32(calcSelect);
                    
                    switch (calcInput)
                    {
                    case 1:
                        Calculator addition01 = new Calculator();
                        Console.WriteLine("Welcome to the Additions section, please enter your selected number : ");
                        string plusNum1 = Console.ReadLine();
                        addition01.num1 = Convert.ToDouble(plusNum1);
                        Console.WriteLine("Please enter your second number : ");
                        string plusNum2 = Console.ReadLine();
                        addition01.num2 = Convert.ToDouble(plusNum2);
                        addition01.Plus();
                        Console.WriteLine("Are you done with Calculabot?");
                        bootAnswer = Console.ReadLine();
                        if (bootAnswer == "Y")
                        {
                            boot = false;

                        }
                        else
                        {
                            Console.WriteLine("Loading biz biz biz");
                        }
                        break;

                    case 2:
                        Calculator substraction01 = new Calculator();
                        Console.WriteLine("Welcome to the Substraction section, please enter your selected number : ");
                        string minusNum1 = Console.ReadLine();
                        substraction01.num1 = Convert.ToDouble(minusNum1);
                        Console.WriteLine("Please enter your second number : ");
                        string minusNum2 = Console.ReadLine();
                        substraction01.num2 = Convert.ToDouble(minusNum2);
                        substraction01.Minus();
                        Console.WriteLine("Are you done with Calculabot?");
                        bootAnswer = Console.ReadLine();
                        if (bootAnswer == "Y")
                        {
                            boot = false;

                        }
                        else
                        {
                            Console.WriteLine("Loading biz biz biz");
                        }
                        break;
                    case 3:
                        Calculator times01 = new Calculator();
                        Console.WriteLine("Welcome to the Multiplication section, please enter your selected number : ");
                        string timesNum1 = Console.ReadLine();
                        times01.num1 = Convert.ToDouble(timesNum1);
                        Console.WriteLine("Please enter your second number : ");
                        string timesNum2 = Console.ReadLine();
                        times01.num2 = Convert.ToDouble(timesNum2);
                        times01.Times();
                        Console.WriteLine("Are you done with Calculabot?");
                        bootAnswer = Console.ReadLine();
                        if (bootAnswer == "Y")
                        {
                            boot = false;

                        }
                        else
                        {
                            Console.WriteLine("Loading biz biz biz");
                        }
                        break;
                    case 4:
                        Calculator by01 = new Calculator();
                        Console.WriteLine("Welcome to the Division section, please enter your selected number : ");
                        string byNum1 = Console.ReadLine();
                        by01.num1 = Convert.ToDouble(byNum1);
                        Console.WriteLine("Please enter your second number : ");
                        string byNum2 = Console.ReadLine();
                        by01.num2 = Convert.ToDouble(byNum2);
                        by01.By();
                        Console.WriteLine("Are you done with Calculabot?");
                        bootAnswer = Console.ReadLine();
                        if (bootAnswer == "Y")
                        {
                            boot = false;

                        }
                        else
                        {
                            Console.WriteLine("Loading biz biz biz");
                        }
                        break;
                    default:
                        Console.WriteLine("-!!!NOOB ALERT!!!/////");
                        Console.WriteLine("You had one job... Pick 1 to 4 next time");
                        Console.WriteLine("-!!!NOOB ALERT!!!/////");
                        Console.WriteLine("Are you done with Calculabot?");
                        bootAnswer = Console.ReadLine();
                        if (bootAnswer == "Y")
                        {
                            boot = false;

                        }
                        else
                        {
                            Console.WriteLine("Loading biz biz biz");
                        }
                        break;
                        


                    }


            }
        }

       



    }
}