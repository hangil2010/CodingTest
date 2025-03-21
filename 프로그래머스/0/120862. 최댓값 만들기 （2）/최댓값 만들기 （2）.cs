using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 1;
        Array.Sort(numbers);
        if( numbers[0] * numbers[1] > numbers[numbers.Length - 1] * numbers[numbers.Length - 2] )
        {
            answer = numbers[0] * numbers[1];
        }
        else
        {
            answer = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];
        }
        return answer;
    }
}