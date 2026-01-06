using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        string answer = "";
        string tempString = "";
        StringBuilder sb = new StringBuilder();
        
        int stringLength = my_string.Length;
        for(int i = 0 ; i < queries.GetLength(0); i++)
        {
            tempString = "";
            if(queries[i,0] != 0)
            {
                sb.Append(my_string.Substring(0, queries[i, 0]));
            }
            
            for(int j = queries[i, 1] ; j >= queries[i, 0] ; j--)
            {
                sb.Append(my_string[j]);
            }
            
            if(queries[i,1] + 1 < stringLength )
            {
                sb.Append(my_string.Substring(queries[i, 1] + 1));
            }
            my_string = sb.ToString();
            sb.Clear();
        }
    
        return answer = my_string;
    }
}