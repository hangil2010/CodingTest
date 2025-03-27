using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2] {0,0};
        for(int i = 0 ; i < keyinput.Length ; i++)
        {
            switch(keyinput[i])
            {
                case "up":
                    if(answer[1] < board[1] / 2)
                    {
                        answer[1]++;
                    }
                    break;
                case "down":
                    if(answer[1] > - (board[1] / 2))
                    {
                        answer[1]--;
                    }
                    break;
                case "left":
                    if(answer[0] > -(board[0] / 2))
                    {
                        answer[0]--;
                    }
                    break;
                case "right":
                    if(answer[0] < (board[0] / 2))
                    {
                        answer[0]++;
                    }
                    break;
            }
        }
        return answer;
    }
}