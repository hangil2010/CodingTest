using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        string answer = "";
        for(int i = 0 ; i < s.Length ; i++){
            if(!dict.ContainsKey(s[i])){
                dict.Add(s[i], 1);
            }
            else
            {
                dict[s[i]]++;
            }
        }
        foreach(char ch in dict.Keys){
            if(dict[ch] == 1){
                answer+=ch;
            }
        }
        answer = String.Concat(answer.OrderBy(ch => ch));
        return answer;
    }
}