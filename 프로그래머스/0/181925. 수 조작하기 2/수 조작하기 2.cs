using System;

public class Solution {
    public string solution(int[] numLog) {
        var answer = new System.Text.StringBuilder();
        for(int i = 1 ; i < numLog.Length ; i++)
        {
            switch(numLog[i] - numLog[i-1])
            {
                case 1:
                    answer.Append("w");
                    break;
                case -1:
                    answer.Append("s");
                    break;
                case 10:
                    answer.Append("d");
                    break;
                case -10:
                    answer.Append("a");
                    break;
            }
        }
        return answer.ToString();
    }
}