using System;
// s 부터 e index의 값이 k의 배수인지 찾고 맞을 경우 +1해라... 
// 0도 포함하는 듯
// [0, 1, 2, 3, 4]

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[] {};
        int length = queries.GetLength(0);
        for(int i = 0 ; i < length ; i++)
        {
            for(int j = queries[i,0] ; j <= queries[i,1] ; j++)
            {
                if(j % queries[i,2] == 0)
                {
                    arr[j]++;
                }
            }
        }
        
        answer = arr;
        
        return answer;
    }
}