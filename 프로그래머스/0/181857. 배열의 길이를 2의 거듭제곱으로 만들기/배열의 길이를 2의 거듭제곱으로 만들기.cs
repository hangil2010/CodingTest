using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int length = 1;
        while(arr.Length > length)
        {
            length *= 2;
        }
        
        int[] answer = new int[length];
        
        for(int i = 0 ; i < arr.Length ; i++)
        {
            answer[i] = arr[i];
        }
        return answer;
    }
}