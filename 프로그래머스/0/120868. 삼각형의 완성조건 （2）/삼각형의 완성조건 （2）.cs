using System;
using System.Linq;
public class Solution {
    public int solution(int[] sides) {
        // 가장 긴 변의 길이 < 다른 두 변의 길이의 합
        int answer = 0;
        int sidesMax = sides.Max();
        int sidesMin = sides.Min();
        for(int i = 1 ; i <= 2000 ; i++){
            if(i <= sidesMax)
            {
                if(sidesMax < i + sidesMin) 
                { 
                    answer++;
                }
            }
            else
            {
                if(i < sidesMax + sidesMin)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}