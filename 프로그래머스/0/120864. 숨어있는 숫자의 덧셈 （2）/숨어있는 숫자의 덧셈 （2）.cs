using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        List<int> numbers = new List<int>();
        string replaced = Regex.Replace(my_string, @"[^0-9]", " ");
        string[] arrays = replaced.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach(string str in arrays)
        {
            answer += int.Parse(str);
        }
        return answer;
    }
}