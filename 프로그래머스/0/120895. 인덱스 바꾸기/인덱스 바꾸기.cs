using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        char[] my_char = my_string.ToCharArray();
        char temp = my_char[num1];
        my_char[num1] = my_char[num2];
        my_char[num2] = temp;
        string answer = string.Join("",my_char);
        return answer;
    }
}