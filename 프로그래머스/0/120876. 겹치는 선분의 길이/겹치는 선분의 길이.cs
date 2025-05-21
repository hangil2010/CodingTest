using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] lines) {
        int[] stackLine = new int[201];
        int answer = 0;
        for(int i = 0 ; i < 3 ; i++)
        {
            for(int j = 0 ; j < 2 ; j++)
            {
                lines[i,j] += 100;
            }
            
            for(int k = lines[i, 0] ; k < lines[i, 1] ; k++)
            {
                stackLine[k]++;
            }
        }
        foreach(int line in stackLine)
        {
            if(line >= 2) answer++;
        }
        return answer;
    }
}