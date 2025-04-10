using System;
using System.Linq;
public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        int[] check = new int[spell.Length];
        bool isOnly = true;
        foreach(string str in dic)
        {
            for(int i = 0 ; i < check.Length ; i++) {check[i] = 0;}
            isOnly = true;
            for(int i = 0 ; i < str.Length ; i++)
            {
                for(int j = 0 ; j < spell.Length ; j++)
                {
                    if(str[i].ToString() == spell[j])
                    {
                        check[j]++;
                    }
                }
            }
            for(int i = 0 ; i < check.Length ; i++)
            {
                if(check[i] != 1) 
                {
                    isOnly = false;
                    break;
                }
            }
            if(isOnly) 
            {
                answer = 1;
                break;
            }
        }
        return answer;
    }
}