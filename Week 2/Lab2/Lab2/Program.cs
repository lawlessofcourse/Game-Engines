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
            int score = 0;
            Random random = new Random();
            
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
            for (int i = 0; i < questionArray.Length; i++)
            {
                int randomNumber = random.Next(0, 5);
                Console.WriteLine(questionArray[randomNumber]);
                userAnswer = Int32.Parse(Console.ReadLine());
                if (userAnswer == answerArray[randomNumber])
                {
                    score += 1;

                }
            }
            Console.WriteLine("Score: " + score);

        }
    }
}