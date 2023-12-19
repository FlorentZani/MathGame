using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

                //Declaration of variables we need to use to keep track of correct answers
                int xAdd = 0;
                int yAdd = 0;
                

                int xSub = 0;
                int ySub = 0;
                

                int xMul = 0;
                int yMul = 0;
                

                int xDiv = 0;
                int yDiv = 0;

                Console.WriteLine("WELCOME TO THE MATH GAME....");
                Console.WriteLine("Press ENTER to continue");

                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                
            //We open a while loop which can be broken only if user decides to press 0-QUIT
            while (true)
            {

                Console.WriteLine("Choose what type of game do you want to play:\n 0-QUIT \n 1-ADDITION \n 2-SUBSTRACTION \n 3-MULTIPLICATION \n 4-DIVISION \n 5-View Score");


                string userInput = Console.ReadLine(); //Gets user input
                int number;

                bool isNum = int.TryParse(userInput, out number); //checks if the user input is a number
                while (!isNum)
                {
                    Console.WriteLine("Input a number from 0 to 5");
                    userInput = Console.ReadLine();
                    isNum = int.TryParse(userInput, out number);
                }
                int i = 0;
                

                while (true)
                {

                    if (number == 0 || number == 1 || number == 2 || number == 3 || number == 4 || number == 5 )
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input a number from 0 to 5");
                        userInput = Console.ReadLine();
                        int.TryParse(userInput, out number);
                    }

                    

                }


                if (number == 0)
                {
                    break;
                }

                else if (number == 5)
                {
                    Console.Clear();
                    Console.WriteLine($"Addition Score: {xAdd} / {yAdd}  ");
                    Console.WriteLine($"Substraction Score:{xSub} / {ySub} ");
                    Console.WriteLine($"Multiplication Score:{xMul} / {yMul} ");
                    Console.WriteLine($"Division Score:{xDiv} / {yDiv}");

                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    Console.Clear();
                   
                }


                else if (number == 1)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    while (i < 5)
                    {
                        i++;
                        Console.WriteLine("You choose the Addition Game ");
                        firstNum = random.Next(0, 100);
                        secondNum = random.Next(0, 100);
                        result = firstNum + secondNum;
                        Console.WriteLine($"{firstNum} + {secondNum}");

                        userInput = Console.ReadLine();
                        while(!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine() ;
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xAdd++;
                            yAdd++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yAdd++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }


                else if (number == 2)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    while (i < 5)
                    {
                        i++;
                        Console.WriteLine("You choose the Substraction Game ");
                        firstNum = random.Next(0, 100);
                        secondNum = random.Next(0, 100);
                        result = firstNum - secondNum;
                        Console.WriteLine($"{firstNum} - {secondNum}");

                        userInput = Console.ReadLine();
                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xSub++;
                            ySub++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            ySub++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }


                else if (number == 3)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    int result;
                    string user;
                    int userAnswer;

                    while (i < 5)
                    {
                        i++;
                        Console.WriteLine("You choose the Multiplication Game ");
                        firstNum = random.Next(0, 100);
                        secondNum = random.Next(0, 100);
                        result = firstNum * secondNum;
                        Console.WriteLine($"{firstNum} * {secondNum}");

                        userInput = Console.ReadLine();

                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xMul++;
                            yMul++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yMul++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else if (number == 4)
                {
                    Console.Clear();
                    Random random = new Random();
                    int firstNum;
                    int secondNum;
                    float result;
                    string user;
                    int userAnswer;

                    while (i < 5)
                    {
                        i++;
                        Console.WriteLine("You choose the Division Game ");
                        do 
                        {
                            firstNum = random.Next(0, 100);
                            secondNum = random.Next(1, 100);
                            result = (float) firstNum / secondNum;
                        }
                        while(Math.Round(result) != result);
                        

                        Console.WriteLine($"{firstNum} / {secondNum}");

                        userInput = Console.ReadLine();
                        while (!int.TryParse(userInput, out userAnswer))
                        {
                            Console.WriteLine("You didnt input a number");
                            userInput = Console.ReadLine();
                        }


                        if (userAnswer == result)
                        {
                            Console.WriteLine("Correct!");
                            xDiv++;
                            yDiv++;

                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            yDiv++;
                        }

                        Console.WriteLine("Type any key for the next question");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

            }
        }
    }
}
