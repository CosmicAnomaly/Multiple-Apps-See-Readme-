using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //         // Assignment 1-1
            //         // Scott Robinson
            //         // 770020625
            //         
            //Console.Write("Please enter the Square Footage you wish to be converted to Square Yards: ");
            //string footageAsString = Console.ReadLine();
            //int squareFootage = Convert.ToInt32(footageAsString);
            //double squareYards = squareFootage * 0.11111111111;
            //Console.WriteLine(squareFootage + " square feet is " + squareYards + " square yards.");
            //Console.ReadKey();

            //         // Assignment 1-2
            //         // Scott Robinson
            //         // 770020625
            //        
            //Console.Write("Please enter the Nautical Leagues you wish to be converted to Nautical Miles: ");
            //string leaguesAsString = Console.ReadLine();
            //int leagues = Convert.ToInt32(leaguesAsString);
            //int nauticalMiles = leagues * 3;
            //Console.Write(leagues + " Nautical Leagues is " + nauticalMiles + " Nautical Miles.");   

            //         // Assignment 1-3
            //         // Scott Robinson
            //         // 770020625
            //
            Console.Write("Please enter Number 1: ");
            string num1AsString = Console.ReadLine();
            int number1 = Convert.ToInt32(num1AsString);
            Console.Write("Please enter Number 2: ");
            string num2AsString = Console.ReadLine();
            int number2 = Convert.ToInt32(num1AsString);
            int sum = number1 + number2;
            int difference = number1 - number2;
            int quotient = number1 / number2;
            int product = number1 * number2;
            int average = (number1 + number2) / 2;
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum + ".");
            Console.WriteLine("The difference of " + number1 + " and " + number2 + " is " + difference + ".");
            Console.WriteLine("The quotient of " + number1 + " and " + number2 + " is " + quotient + ".");
            Console.WriteLine("The product of " + number1 + " and " + number2 + " is " + product + ".");
            Console.WriteLine("The average of " + number1 + " and " + number2 + " is " + average + ".");

            //        // Assignment 1-4
            //        // Scott Robinson
            //        // 770020625
            // 
            //Console.Write("Please enter the amount of hours you worked: ");
            //string hoursAsString = Console.ReadLine();
            //int hours = Convert.ToInt32(hoursAsString);
            //Console.Write("Please enter your rate of pay: ");
            //string rateAsString = Console.ReadLine();
            //float rate = Convert.ToSingle(rateAsString);
            //float grossPay = rate * hours;
            //Console.WriteLine("Your gross pay is: {0:C}", grossPay);
            //float federalTax = grossPay * .2f;
            //Console.WriteLine("You will pay {0:C} in federal taxes", federalTax);
            //// string strFederalTax = String.Format("{0:C}", federalTax);
            //// Console.WriteLine("You will pay " + strFederalTax + " in federal taxes."); // Why doesn't Console.WriteLine("You will pay {0:C}", federalTax + " in federal taxes.") work?
            //float stateTax = grossPay * .05f;
            //Console.WriteLine("In State taxes you will pay {0:C}", stateTax);
            //float socialSecurity = grossPay * .062f;
            //Console.WriteLine("In Social Security tax you will pay {0:C}", socialSecurity);
            //float netPay = grossPay - federalTax - stateTax - socialSecurity;
            //Console.WriteLine("Your net pay after tax deductions is: {0:C}", netPay);

            //       // Assignment 1-5
            //       // Scott Robinson
            //       // 770020625
            //
            //Console.WriteLine("As I was going to St. Ives, I met a man with seven wives. Every wife had seven sacks, every sack had seven cats, and every cat had seven kittens. Kittens, cats, sacks, and wives, how many were going to St. Ives?" + "\n\n");
            //int Man = 1;
            //Console.WriteLine("The narrator met " + Man + " Man.");
            //int Wives = 7;
            //Console.WriteLine("That man had " + Wives + " Wives.");
            //int Sacks = Wives * 7;
            //Console.WriteLine("Each of the mans wives had 7 sacks, for a total of " + Sacks + " sacks.");
            //int Cats = Sacks * 7;
            //Console.WriteLine("Each of the wives sacks had 7 cats, for a total of " + Cats + " Cats.");
            //int Kittens = Cats * 7;
            //Console.WriteLine("Each of the sacks cats had 7 kittens, for a total of " + Kittens + " kittens.");
            //int totalMet = Man + Wives + Sacks + Cats + Kittens;
            //Console.WriteLine("The total number of things the narrator met is " + totalMet + ".");
            //Console.ReadKey();

            //       // Assignment 1-6
            //       // Scott Robinson
            //       // 770020625
            //
            //Console.Write("Please enter the amount of change you would like converted: ");
            //string changeString = Console.ReadLine();
            //int change = Convert.ToInt32(changeString);
            //int Quarters = change / 25;
            //change = change % 25;
            //int Dimes = change / 10;
            //change = change % 10;
            //int Nickels = change / 5;
            //change = change % 5;
            //int Pennies = change / 1;
            //change = change % 1;
            //Console.WriteLine("Quarters: " + Quarters);
            //Console.WriteLine("Dimes: " + Dimes);
            //Console.WriteLine("Nickels: " + Nickels);
            //Console.WriteLine("Pennies: " + Pennies);

            //      // Assignment 1-7
            //      // Scott Robinson
            //      // 770020625
            //
            //Console.Write("Please enter the size of Jake's Gas Tank: ");
            //string tankString = Console.ReadLine();
            //int tank = Convert.ToInt32(tankString);
            //Console.Write("Please enter the miles Jake has traveled: ");
            //string traveledString = Console.ReadLine();
            //int traveled = Convert.ToInt32(traveledString);
            //Console.Write("Please enter the amounts of gallons still remaining: ");
            //string gallonsString = Console.ReadLine();
            //int gallons = Convert.ToInt32(gallonsString);
            //int total1 = tank - gallons;
            //int total2 = traveled / total1;
            //Console.WriteLine("Jake is getting " + total2 + " miles per gallon.");
            //int total3 = total2 * gallons;
            //Console.WriteLine("With the remaining " + gallons + " gallons, Jake can travel " + total3 + " miles.");
            //int total4 = total2 * tank;
            //Console.WriteLine("On a full tank of gas, Jake can travel " + total4 + " miles.");



            Console.ReadKey();
        }
    }
}




