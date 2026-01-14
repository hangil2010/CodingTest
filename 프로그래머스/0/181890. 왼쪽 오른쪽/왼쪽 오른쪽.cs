using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] str_list) {
        List<string> strList = new List<string>();
        
        int rIndex = Array.IndexOf(str_list, "r");
        int lIndex = Array.IndexOf(str_list, "l");
        
        if (rIndex == -1 && lIndex == -1)
        {
            Console.WriteLine("Case A");
            return strList.ToArray();
        }
        else if (rIndex == -1)
        {
            if(lIndex - 1 >= 0)
            {
                for(int i = 0 ; i <= lIndex -1 ; i++)
                {
                    strList.Add(str_list[i]);
                }
            }
        }
        else if (lIndex == -1)
        {
            if(rIndex + 1 <= str_list.Length)
            {
                for(int i = rIndex + 1 ; i < str_list.Length ; i++)
                {
                    strList.Add(str_list[i]);
                }
            }
        }
        else if (lIndex < rIndex)
        {
            if(lIndex - 1 >= 0)
            {
                for(int i = 0 ; i <= lIndex -1 ; i++)
                {
                    strList.Add(str_list[i]);
                }
            }
        }
        else if (rIndex < lIndex)
        {
            if(rIndex + 1 <= str_list.Length)
            {
                for(int i = rIndex + 1 ; i < str_list.Length ; i++)
                {
                    strList.Add(str_list[i]);
                }
            }
        }

        return strList.ToArray();
    }
}