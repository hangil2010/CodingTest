using System;
public class Solution {
    public int solution(string A, string B) {
        bool isSame = false;
        string[] subA = new string[2];
        int answer = 0;
        int count = 0;
        for(int i = 0 ; i < B.Length ; i++)
        {
            if(A == B) { break; }
            else
            {
                subA[0] = A.Substring(0, A.Length -1);
                subA[1] = A.Substring(A.Length -1 );
                A = $"{subA[1]}{subA[0]}";
                count++;
            }
        }
        if(count == B.Length) 
        {
            answer = -1;
        }
        else
        {
            answer = count;  
        }
        return answer;
    }
}