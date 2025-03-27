using System;

public class Solution {
    public int solution(int M, int N) {
        int answer = 0;
        // 가로 자를 횟수 = 길이 - 1
        // 세로 자를 횟수 = 세로길이 x 가로 자를 횟수 - 1
        if(M == 1 && N == 1) {return 0;}
        int horzCut = M - 1;
        int vertiCut = N * (M - 1) - 1;
        answer = horzCut + vertiCut;
        return M*N-1;
    }
}