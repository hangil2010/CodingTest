using System;

public class Solution {
    public int solution(int[] box, int n) {
        int answer = 
            (int)(box[0]/n) *
            (int)(box[1]/n) *
            (int)(box[2]/n) ;
        return answer;
    }
}