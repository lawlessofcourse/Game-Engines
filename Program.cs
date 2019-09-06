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

            

            Console.Write("What is your name?");
            name = Console.ReadLine();

            Console.Write("How old are you?");
            userAge = Console.ReadLine();
            intVal = Convert.ToInt32(userAge);
            ourAge = myAge + intVal;
            Console.Write("What is your favorite game?");
            favGame = Console.ReadLine();

            Console.WriteLine("Hello " + name + "!" + " You are " + userAge + " and your favorite game is " + favGame + "!");
            Console.WriteLine("Our ages added together would equal " + ourAge);


          
        }
    }
}
