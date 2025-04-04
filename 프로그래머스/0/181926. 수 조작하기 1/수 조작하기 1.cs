using System;

public class Solution {
    public int solution(int n, string control) {
        char[] input = control.ToCharArray();
        int answer = n;
        for(int i = 0 ; i < input.Length ; i++)
        {
            switch(input[i])
            {
                case 'w':
                    answer += 1;
                    break;
                case 's':
                    answer -= 1;
                    break;
                case 'd':
                    answer += 10;
                    break;
                case 'a':
                    answer -= 10;
                    break;
            }
        }
        return answer;
    }
}