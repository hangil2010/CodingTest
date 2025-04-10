using System;
using System.Linq;
public class Solution {
    public int[] solution(int[,] score) {
        int len = score.GetLength(0);
        int[] answer = new int[len] ;
        Array.Fill(answer, 1);
        int[] scoreAvg = new int[len];
        for(int i = 0 ; i < len ; i++)
        {
            scoreAvg[i] = (score[i,0] + score[i,1]);
        }
        for(int i = 0 ; i < len ; i++)
        {
            for(int j = 0 ; j < len ; j++)
            {
                if(scoreAvg[i] > scoreAvg[j])
                {
                    answer[j]++;
                }
            }
        }
        return answer;
    }
}