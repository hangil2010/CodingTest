using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        int[] answer = new int[] {};
        List<int> sol = new List<int>();
        
        while(n != 1)
        {
            sol.Add(n);
            if(n%2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3*n+1;
            }
        }
        sol.Add(n);
        
        answer = sol.ToArray();
        
        return answer;
    }
}