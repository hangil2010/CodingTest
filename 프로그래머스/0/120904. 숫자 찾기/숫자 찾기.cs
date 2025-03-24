using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        string numStr = num.ToString();
        char[] numChar = numStr.ToCharArray();
        for(int i = 0 ; i < numChar.Length ; i++)
        {
            if(numChar[i].ToString() == k.ToString())
            {
                answer = i+1;
                break;
            }
        }
        return answer;
    }
}