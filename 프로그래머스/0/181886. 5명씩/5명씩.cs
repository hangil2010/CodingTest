using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] names) {
        List<string> sol = new List<string>();
        
        for(int i = 0 ; i < names.Length ; i++)
        {
            if(i % 5 == 0)
            {
                sol.Add(names[i]);
            }
        }
        return sol.ToArray();
    }
}