using System;

public class Solution {
    public int Max(int x, int y){
        return x >= y ? x : y;
    } 
    public int Min(int x, int y){
        return x <= y ? x : y;
    }
    public int solution(int[,] dots) {
        int xMax = Max(Max(dots[0,0], dots[1,0]),Max(dots[2,0],dots[3,0]));
        int xMin = Min(Min(dots[0,0], dots[1,0]),Min(dots[2,0],dots[3,0]));
        int yMax = Max(Max(dots[0,1], dots[1,1]),Max(dots[2,1],dots[3,1]));
        int yMin = Min(Min(dots[0,1], dots[1,1]),Min(dots[2,1],dots[3,1]));
        int length = Math.Abs(xMax - xMin);
        int width = Math.Abs(yMax - yMin);
        return length * width;
    }
}