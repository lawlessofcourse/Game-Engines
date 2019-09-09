using System;

namespace Notes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            String[] questionArray = new string[5];
            int[] answerArray = new int[5];
            int userAnswer;
            int score=0;
            const int myAge = 22;
            string userAge;
            int ourAge;
            int intVal;
            string name = "Bob";
            string favGame = "The Witcher 3";
            var rand = new Random();
            questionArray[0] = "What is 2+3?";
            questionArray[1] = "What is 5+4?";
            questionArray[2] = "What is 10+6?";
            questionArray[3] = "What is 5+8?";
            questionArray[4] = "What is 3+9?";

            answerArray[0] = 5;
            answerArray[1] = 9;
            answerArray[2] = 16;
            answerArray[3] = 13;
            answerArray[4] = 12;

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

            Console.WriteLine("Wanna play a game?");
            
            for (int i = 0; i < questionArray.Length; i++) {
                int randomOne = rand.Next(0, intVal);
                int randomTwo = rand.Next(0, intVal);
                int ans = randomOne + randomTwo;
                QuestionAnswer myQA = new QuestionAnswer(questionArray[i], answerArray[i]);
                Console.WriteLine(myQA.getQuestion());
                userAnswer = Int32.Parse(Console.ReadLine());
                if (userAnswer != myQA.getAnswer())
                {
                    i -= 1;
                    score -= 1;
                    
                    Console.WriteLine("INCORRECT! Try again :)");

                }
                else if (userAnswer == myQA.getAnswer())
                {
                    score += 1;
                    Console.WriteLine("That is correct! The answer is " + myQA.getAnswer() + "!");
                } 
                else if (i == questionArray.Length)
                {

                    Console.WriteLine("You have finished!");
                }

                
            }
            Console.WriteLine("You have finished! You scored " + score + " out of 5");



            /*
            //prinmitive array
            int[] myAnswerArray = { 3,5,7,11,13}; 

            //
            String[] myQuestionArray = new string[5];

            for(int i = 0; i<myAnswerArray.Length; i++)
            {
                myAnswerArray[i] = i + 5;
            }
            for (int i = 0; i < myAnswerArray.Length; i++)
            {
                Console.WriteLine(myAnswerArray[i]);
            }

            int sizeOfArray = Int32.Parse(Console.ReadLine());
            //myAnswerArray = new int[sizeOfArray];
          
            */













            //creating new random object
            //class name variable name = instance of class
            /*
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(4, 10);



            if (randomNumber<7 && randomNumber>0)
            {
                Console.Write("You are less than seven and greater than zero");
            }
            else if(randomNumber>6)
            {
                Console.Write("You are greater than 6");
            }
            else
            {
                Console.Write("idk whats goin on dood");
            }
            Console.Write("What is your name?");
            String name = Console.ReadLine();

            Console.Write("What is your age?");
            int age = Int32.Parse(Console.ReadLine());
            */

        }
    }
}
