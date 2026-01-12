using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        List<int> arrList = arr.ToList();
        
        int start = arrList.IndexOf(2);
        int end = arrList.LastIndexOf(2);
        
        if(start == -1)
        {
            answer.Add(-1);
        }
        else
        {
            for(int i = start ; i <= end ; i++)
            {
                answer.Add(arr[i]);
            }
        }
        
        return answer.ToArray();
    }
}