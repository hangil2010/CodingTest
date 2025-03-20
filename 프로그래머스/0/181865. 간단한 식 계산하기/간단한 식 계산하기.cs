using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        string[] form = binomial.Split(' ');
        switch(form[1]){
            case "+":
                answer = int.Parse(form[0]) + int.Parse(form[2]);
                break;
            case "-":
                answer = int.Parse(form[0]) - int.Parse(form[2]);
                break;
            case "*":
                answer = int.Parse(form[0]) * int.Parse(form[2]);
                break;
        }
        return answer;
    }
}