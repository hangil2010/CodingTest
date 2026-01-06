using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        int[] answer = new int[] {};
        Queue<int> sol = new Queue<int>();
        for(int i = start_num ; i <= end_num ; i++)
        {
            sol.Enqueue(i);
        }
        
        answer = sol.ToArray();
        return answer;
    }
}