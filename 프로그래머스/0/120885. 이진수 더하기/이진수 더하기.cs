using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        int b1 = Convert.ToInt32(bin1, 2);
        int b2 = Convert.ToInt32(bin2, 2);
        int sum = b1+b2;
        string answer = Convert.ToString(sum, 2);
        return answer;
    }
}