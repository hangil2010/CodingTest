using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        Stack<int> stk = new Stack<int>();
        
        for(int i = 0 ; i < arr.Length ; i++)
        {
            if(stk.Count == 0)
            {
                stk.Push(arr[i]);
            }
            else if (stk.Peek() == arr[i])
            {
                stk.Pop();
            }
            else if (stk.Peek() != arr[i])
            {
                stk.Push(arr[i]);
            }
        }
        
        if(stk.Count == 0)
        {
            answer = new int[1]{-1};
        }
        else
        {
            answer = stk.ToArray();
            Array.Reverse(answer);
        }
        
        return answer;
    }
}