using System;
using System.Linq;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        string[] anyFilter = order.Select(s => s == "anything" ? s = "americano": s).ToArray();
        
        foreach(string str in anyFilter)
        {
            if(str.Contains("americano"))
            {
                answer+=4500;
            }
            else if (str.Contains("cafelatte"))
            {
                answer+=5000;
            }
        }
        return answer;
    }
}