//All the code is use in the system
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The name of this project
namespace Unit_16_P2
{
    // All the code is done inside the class program
    class Program
    {
        // All the input will change to text
        static void Main(string[] args)
        {
            // This allow the operation to change to text conversion
            string operation;
            // This allow the first number to change to number conversion
       
            int firstNum;
           // This allow the second number to change to number conversion
            int secondNum;
            // This allow the answer to change to number conversion
            int answer;


            // This two code for welcome the user to use the application
            Console.WriteLine("welcome to the RTW calculator!");
            Console.Write("let start! ");


            // Ask the user to enter they first number
            Console.Write("Enter the first number in your basic equation: ");
            // This code is change the first number to change to 32 bit signed number
            firstNum = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter they second number
            Console.Write("Now enter your second number in the basic equation: ");
            // This code is change the second number to change to 32 bit signed number
            secondNum = Convert.ToInt32(Console.ReadLine());
            // Ask the user to pick their operation
            Console.Write("Enter your operation (x,/,+,-)");
            // Let the user to read the code
            operation = Console.ReadLine();
            // when the user pick x will run this code
            if (operation == "x")
            {
                // the code show how to multiplication
                answer = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            // when the user pick / will run this code
            else if (operation == "/")
            {
                // the code show how to division
                answer = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            // when the user pick + will run this code
            else if (operation == "+")
            {
                // the code show how to addition
                answer = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            // when the user pick - will run this code
            else if (operation == "-")
            {
                // the code show how to subtraction
                answer = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + answer);
                Console.ReadLine();
            }
            // If the user doesn't pick this operation then the code can still run
            else
            {
                // the code will output the sentence and ask the user to restart the code again
                Console.WriteLine("Sorry that is not correct format! Please restart!");
                Console.ReadLine();
            }
        } 
    }
}



