using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string my_string) {
        char[] charList = my_string.Distinct().ToArray();
        string answer = string.Concat(charList);
        return answer;
    }
}