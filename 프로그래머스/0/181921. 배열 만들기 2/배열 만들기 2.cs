using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] {};
        List<int> answerList = new List<int>();
        for(int i = l ; i <= r ; i++)
        {
            bool is5or0Only = true;
            
            if(i % 5 == 0)
            {
                string check = i.ToString();
                foreach(char c in check)
                {
                    if(c != '5')
                    {
                         if(c != '0')
                        {
                            is5or0Only = false;
                            break;
                        }
                    }  
                }
                
                if(is5or0Only == true)
                {
                    answerList.Add(i);
                }
            }
        }
        
        if(answerList.Count == 0)
        {
            answerList.Add(-1);
        }
        
        answer = answerList.ToArray();
        return answer;
    }
}