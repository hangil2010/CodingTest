using System;

public class Solution {
    public int solution(int[,] board) {
        int n = board.GetLength(0);
        bool[,] danger = new bool[n, n];
        int answer = 0;

        int[] dy = {-1, -1, -1, 0, 0, 1, 1, 1};
        int[] dx = {-1,  0,  1,-1, 1,-1, 0, 1};

        for (int y = 0; y < n; y++) {
            for (int x = 0; x < n; x++) {
                if (board[y, x] == 1) {
                    danger[y, x] = true;
                    for (int d = 0; d < 8; d++) {
                        int ny = y + dy[d];
                        int nx = x + dx[d];
                        if (ny >= 0 && ny < n && nx >= 0 && nx < n)
                            danger[ny, nx] = true;
                    }
                }
            }
        }
        
        for (int y = 0; y < n; y++) {
            for (int x = 0; x < n; x++) {
                if (!danger[y, x])
                    answer++;
            }
        }

        return answer;
    }
}