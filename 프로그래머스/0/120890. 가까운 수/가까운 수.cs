using System;
using System.Linq;
public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int distnce = 100;
        Array.Sort(array);
        
        for(int i = 0 ; i < array.Length ; i++){
            if(Math.Abs(array[i] - n) < distnce){
                distnce = Math.Abs(array[i] - n);
                answer = array[i];
            }
        }
        
        return answer;
    }
}