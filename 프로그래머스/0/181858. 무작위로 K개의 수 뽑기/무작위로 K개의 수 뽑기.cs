using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> arrList = arr.ToList();
        List<int> answer = new List<int>();
        int[] dist = arrList.Distinct().ToArray();
        
        if(dist.Length < k)
        {
            for(int i = 0 ; i < dist.Length; i++)
            {
                answer.Add(dist[i]);
            }
            for(int i = dist.Length ; i < k ; i++)
            {
                answer.Add(-1);
            }
        }
        else
        {
            for(int i = 0 ; i < k ; i++)
            {
                answer.Add(dist[i]);
            }
        }
        
        return answer.ToArray();
    }
}