using System;

public class QuestionAnswer
{
   
    private String question;
    private int answer;

    public QuestionAnswer(string question, int answer)
    { 
        this.question = question;       
        this.answer = answer;
	}

    public String getQuestion()
    {

      
        return question;
    }

    public int getAnswer()
    {
        return answer;
    }
}
