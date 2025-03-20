using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        if(hp > 5)
        {
            answer+=(int)hp/5;
            hp-=((int)hp/5)*5;
        }
        if(2 < hp && hp < 5)
        {
            answer++;
            hp-=3;
        }
        if(hp <= 2){
            answer+=hp;
        }
        return answer;
    }
}