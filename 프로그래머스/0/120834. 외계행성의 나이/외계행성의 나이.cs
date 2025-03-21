using System;
public class Solution {
    public string solution(int age) {
        if(age == 1000) {return "baaa";}
        string result = "";
        string[] newAge = new string[10]
        {"a","b","c","d","e","f","g","h","i","j"};
        string ageStr = age.ToString();
        foreach(char c in ageStr){
            result += newAge[int.Parse(c.ToString())];
        }
        
        return result;
    }
}