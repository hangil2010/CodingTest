using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int takeNum = 3;
        int[] top3 = new int[takeNum];
        
        int[] result = 
            rank
            .Where((item, index) => attendance[index] == true)
            .OrderBy(x => x)
            .Take(takeNum)
            .ToArray();
        
        for(int i = 0 ; i < takeNum ; i++)
        {
            top3[i] = Array.IndexOf(rank, result[i]);
        }
        
        return 10000 * top3[0] + 100 * top3[1] + top3[2];
    }
}