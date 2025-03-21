using System;

public class Solution {
    public int solution(int balls, int share) {
        // n x n-1 x n-2 x ... x n-m+1 / m!
        // balls x balls-1 x balls-2 x ... x share+1 / share!
        long answer = 1;
        long divide = 1;
        for(int i = share+1 ; i <= balls ; i++)
        {
            answer *= i;
            answer = answer / divide;
            divide++;
        }
        return (int)answer;
    }
}