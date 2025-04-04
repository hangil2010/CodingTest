using System;

public class Solution {
    public int solution(int[] num_list) {
        int oddSum = 0;
        int evenSum = 0;
        int answer = 0;
        for(int i = 0 ; i < num_list.Length ; i++)
        {
            if(num_list[i] % 2 == 1)
            {
                oddSum *= 10;
                oddSum += num_list[i];
            }
            else
            {
                evenSum *= 10;
                evenSum += num_list[i];
            }
        }
        return oddSum + evenSum;
    }
}