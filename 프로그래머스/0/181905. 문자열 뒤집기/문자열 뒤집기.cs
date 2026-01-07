using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string answer = "";
        var arr = my_string.ToCharArray();
        Array.Reverse(arr, s, e - s + 1);
        return new string(arr);
    }
}