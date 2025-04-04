using System;

public class Solution {
    public int solution(int[] num_list) {
        int sum = 0;
        int multi = 1;
        int answer = 0;
        foreach(int i in num_list)
        {
            sum += i;
            multi *= i;
        }
        return multi < (int)Math.Pow(sum, 2) ? 1 : 0;
    }
}