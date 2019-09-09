using System;
using System.Collections.Generic;





namespace MyFirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            const int myAge = 22;
            string userAge;
            int ourAge;
            int intVal;
            string name = "Bob";
            string favGame = "The Witcher 3";
            int randomOne;
            int randomTwo;
            var rand = new Random();
            int answer;
            string userAnswer;
            int parseAnswer;

            Console.Write("What is your name?");
            name = Console.ReadLine();

            Console.Write("How old are you?");
            userAge = Console.ReadLine();
            intVal = Convert.ToInt32(userAge);
            ourAge = intVal + myAge;
            Console.Write("What is your favorite game?");
            favGame = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!" + " You are " + userAge + " and your favorite game is " + favGame + "!");
            Console.WriteLine("Our ages added together would be " + ourAge + "!");
            randomOne = rand.Next(0, intVal);
            randomTwo = rand.Next(0, intVal);
            answer = randomOne + randomTwo;
            Console.WriteLine("Wanna play a game?");
            Console.WriteLine("What is " + randomOne + " + " + randomTwo + "?");
            userAnswer = Console.ReadLine();
            parseAnswer = Convert.ToInt32(userAnswer);

            if (parseAnswer == answer)
            {
                Console.WriteLine("That is correct!");
                randomOne = rand.Next(0, intVal);
                randomTwo = rand.Next(0, intVal);
                answer = randomOne + randomTwo;
                score++;
            }
            else
            {
                Console.WriteLine("You suck at Math, try some meth");
            }

            Console.WriteLine("What is " + randomOne + " + " + randomTwo + "?");
            userAnswer = Console.ReadLine();
            parseAnswer = Convert.ToInt32(userAnswer);
            if (parseAnswer == answer)
            {
                Console.WriteLine("That is correct!");
                randomOne = rand.Next(0, intVal);
                randomTwo = rand.Next(0, intVal);
                answer = randomOne + randomTwo;
                score++;
            }
            else
            {
                Console.WriteLine("We are doing math not meth.");
            }
            Console.WriteLine("You scored a " + score);
        }
    }
}
