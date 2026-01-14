using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = arr;
        
        for(int i = 0 ; i < answer.Length ; i++)
        {
            for(int j = 0 ; j < queries.GetLength(0) ; j++)
            {
                if(queries[j,0] <= i && i <= queries[j,1])
                {
                    answer[i]++;
                }
            }
        }
        
        return answer;
    }
}