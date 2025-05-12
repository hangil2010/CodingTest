using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int num, int total) {
        // 등차수열 : 횟수(시작값 + 끝값) / 2
        // total = num(start + end) / 2
        // total = num(start + start + num - 1) / 2
        // total = num(2start + num - 1) / 2
        // 2total = num(2start + num - 1)
        // 2total / num = 2start + num - 1
        // ((2total/num) - num + 1 ) / 2 = start
        List<int> answer = new List<int>();
        int start = ((2*total/num) - num + 1) / 2;
        for(int i = 0 ; i < num ; i++)
        {
            answer.Add(start+i);
        }
        return answer.ToArray();
    }
}