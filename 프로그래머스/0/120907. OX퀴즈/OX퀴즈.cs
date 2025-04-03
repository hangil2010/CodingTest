using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string[] quiz) {
        List<string> answer = new List<string>();
        string correct = "";
        for(int i = 0 ; i < quiz.Length ; i++)
        {
            string[] quizSub = quiz[i].Split(" ");
            if(quizSub[1] == "+")
            {
                if(int.Parse(quizSub[4]) == int.Parse(quizSub[0]) + int.Parse(quizSub[2]))
                {
                    correct = "O";
                }
                else
                {
                    correct = "X";
                }
            }
            else if(quizSub[1] == "-")
            {
                if(int.Parse(quizSub[4]) == int.Parse(quizSub[0]) - int.Parse(quizSub[2]))
                {
                    correct = "O";
                }
                else
                {
                    correct = "X";
                }
            }
            answer.Add(correct);
        }
        return answer.ToArray();
    }
}