using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        for(int i = 0 ; i < array.Length ; i++){
            string luck = array[i].ToString();
            char[] lucks = luck.ToCharArray();
            for(int j = 0 ; j < lucks.Length; j++){
                if(lucks[j] == '7'){
                    answer++;
                }
            }
        }
        return answer;
    }
}