using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();
        for(int i = 2 ; i <= n ; i++){
            if(n % i == 0){
                answer.Add(i);
            }
            while(n % i == 0) {n/=i;}
        }
        return answer.ToArray();
    }
}