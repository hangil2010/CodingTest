using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string myString) {
        List<int> answer = new List<int>();
        string[] stringCut = myString.Split('x');
        
        for(int i = 0 ; i < stringCut.Length ; i++)
        {
            answer.Add(stringCut[i].Length);
        }
        return answer.ToArray();
    }
}