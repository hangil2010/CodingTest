using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int[] query) {
        List<int> arrList = arr.ToList();
        
        for(int i = 0 ; i < query.Length ; i++)
        {
            
            if(i % 2 == 0)
            {
                arrList = arrList.Take(query[i] + 1).ToList();
            }
            else
            {
                arrList = arrList.Skip(query[i]).ToList();
            }
            
        }
        
        
        return arrList.ToArray();
    }
}