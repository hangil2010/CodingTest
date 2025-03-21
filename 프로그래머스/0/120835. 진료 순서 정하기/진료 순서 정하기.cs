using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        
        for(int i = 0 ; i < emergency.Length ; i++)
        {
            for(int j = 0 ; j < emergency.Length ; j++)
            {
                if(emergency[i] <= emergency[j]){
                answer[i]++;
                }
            }
            //answer[i]++;
        }
        return answer;
    }
}