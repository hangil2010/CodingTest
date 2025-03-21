using System;

public class Solution {
    public int solution(int n) {
        int pow = 1;
        while(pow <= 1000)
        {
            if(Math.Pow(pow, 2) == n)
            {
                return 1;
                break;
            }
            pow++;
        }
        return 2;
    }
}