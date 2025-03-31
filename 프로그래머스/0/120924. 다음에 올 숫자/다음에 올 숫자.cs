using System;
using System.Linq;
public class Solution {
    public int solution(int[] common) {
        bool check = false;
        int answer = common.Last();
        check = common[1] - common[0] == common[2] - common[1] ? true : false;
        if(check)
        {
            answer += common[1] - common[0];
        }
        else
        {
            answer *= common[1] / common[0];
        }
        return answer;
    }
}