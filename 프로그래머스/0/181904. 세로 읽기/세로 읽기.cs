using System;
using System.Text;
// m * index + (c -1)
// 
public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        
        StringBuilder sb = new StringBuilder();
        
        char[] my_char = my_string.ToCharArray();
        
        int index = 0;
        while(m * index < my_string.Length)
        {
            sb.Append(my_char[m * index + c - 1]);
            index++;
        }
        
        return answer = sb.ToString();
    }
}