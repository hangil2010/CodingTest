using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] answer = new int[,] {{}};
        int row = arr.GetLength(0);
        int col = arr.GetLength(1);
        if(row != col)
        {
            if(row > col)
            {
                answer = new int [row, row];
                Array.Clear(answer, 0, answer.Length);
                
                for(int i = 0 ; i < row ; i++)
                {
                    for(int j = 0 ; j < col; j++)
                    {
                        answer[i, j] = arr[i, j];
                    }
                }
            }
            else
            {
                answer = new int [col, col];
                Array.Clear(answer, 0, answer.Length);
                
                for(int i = 0 ; i < row ; i++)
                {
                    for(int j = 0 ; j < col; j++)
                    {
                        answer[i, j] = arr[i, j];
                    }
                }
            }
        }
        else
        {
            answer = arr;
        }
        return answer;
    }
}