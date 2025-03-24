using System;

public class Solution {
    public bool IsMax(int n, int m)
    {
        return n > m ? false : true ; 
    }
    public int[] solution(int[] array) {
        int[] answer = new int[2];
        answer[0] = array[0];
        answer[1] = 0;
        for(int i = 0 ; i < array.Length ; i++)
        {
            if(IsMax(answer[0], array[i]))
            {
                answer[0] = array[i];
                answer[1] = i;
            }
        }
        return answer;
    }
}