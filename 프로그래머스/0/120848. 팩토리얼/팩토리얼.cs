using System;

public class Solution {
    public int fact(int n){
        int num = 1;
        if(n == 0 || n == 1) { return 1; }
        for(int i = n;  i >= 1 ; i--) { num *= i; }
        return num;
    }
    public int solution(int n) {
        int answer = 1;
        while(fact(answer) < n) { answer++;}
        if(fact(answer) > n ) {answer--;}
        return answer;
    }
}