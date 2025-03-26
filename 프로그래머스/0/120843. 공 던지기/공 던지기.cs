using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int round = 0;
        int answer = 0;
        
        for(int i = 0 ; i < k ; i++){
            if(round >= numbers.Length) 
            {
                round%=numbers.Length;
            }
            answer = numbers[round];
            round+=2;
        }
        return answer;
    }
}