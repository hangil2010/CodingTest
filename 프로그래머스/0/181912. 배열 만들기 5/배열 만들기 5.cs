using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] intStrs, int k, int s, int l) {
        int[] answer = new int[] {};
        List<int> solList = new List<int>(intStrs.Length);
        
        foreach(string str in intStrs)
        {
            int value = int.Parse(str.Substring(s, l));
            if(value > k)
            {
                solList.Add(value);
            }
        }
        return answer = solList.ToArray();
    }
}