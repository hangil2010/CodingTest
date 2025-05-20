using System;

public class Solution {
    public int solution(int[,] dots) {
        // 1,2 3,4 1,3 2,4
        int answer = 0;
        double x1x2 = Math.Max(dots[0,0],dots[1,0]) - Math.Min(dots[0,0], dots[1,0]);
        double y1y2 = Math.Max(dots[0,1],dots[1,1]) - Math.Min(dots[0,1], dots[1,1]);
        double x3x4 = Math.Max(dots[2,0],dots[3,0]) - Math.Min(dots[2,0], dots[3,0]);
        double y3y4 = Math.Max(dots[2,1],dots[3,1]) - Math.Min(dots[2,1], dots[3,1]);
        double line1 = y1y2 / x1x2;
        double line2 = y3y4 / x3x4;
        if(line1 == line2) return 1;

        double x1x3 = Math.Max(dots[0,0],dots[2,0]) - Math.Min(dots[0,0], dots[2,0]);
        double y1y3 = Math.Max(dots[0,1],dots[2,1]) - Math.Min(dots[0,1], dots[2,1]);
        double x2x4 = Math.Max(dots[1,0],dots[3,0]) - Math.Min(dots[1,0], dots[3,0]);
        double y2y4 = Math.Max(dots[1,1],dots[3,1]) - Math.Min(dots[1,1], dots[3,1]);
        double line3 = y1y3 / x1x3;
        double line4 = y2y4 / x2x4;
        if(line3 == line4) return 1;
        return answer;
    }
}