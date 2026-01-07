using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[] {};
        List<string> head = new List<String>();
        
        for(int i = 0 ; i < my_string.Length ; i++)
        {
            head.Add(my_string.Substring(i));
        }
        
        Array.Sort(answer = head.ToArray());
        
        return answer;
    }
}