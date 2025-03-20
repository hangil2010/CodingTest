using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        foreach(int i in array)
        {
            if(i == n)
            {
                answer++;
            }
        }
        return answer;
    }
}