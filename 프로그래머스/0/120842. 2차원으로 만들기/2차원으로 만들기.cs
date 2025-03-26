using System;
using System.Collections.Generic;
public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n,n];
        int index = 0;
        for(int i = 0 ; i < num_list.Length/n ; i++){
            for(int j = 0 ; j < n ; j++){
                answer[i,j] = num_list[index];
                index++;
            }
        }
        return answer;
    }
}