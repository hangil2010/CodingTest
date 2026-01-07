using System;
using System.Text;

public class Solution {
    public string solution(int q, int r, string code) {
        StringBuilder sb = new StringBuilder();
        for(int index = 0 ; index < code.Length ; index++)
        {
            if(index % q == r)
            {
                sb.Append(code[index].ToString());
            }
        }
        
        return sb.ToString();
    }
}