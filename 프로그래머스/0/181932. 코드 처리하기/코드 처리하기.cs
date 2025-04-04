using System;
public class Solution {
    public string solution(string code) {
        string answer = "EMPTY";
        string ret = "";
        int mode = 0;
        for(int idx = 0 ; idx < code.Length ; idx++)
        {
            if(mode == 0)
            {
                if(code[idx] != '1')
                {
                    if(idx % 2 == 0)
                    {
                        ret+=code[idx];
                    }
                }
                else
                {
                    mode = 1;
                }
                
            }
            else if(mode == 1)
            {
                if(code[idx] != '1')
                {
                    if(idx % 2 == 1)
                    {
                        ret+=code[idx];
                    }
                }
                else 
                {
                    mode = 0;
                }
            }
        }
        if(ret != "")
        {
            answer = ret;
        }
        return answer;
    }
}