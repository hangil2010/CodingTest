using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for(int i = 0 ; i < queries.GetLength(0) ; i++)
        {   
            int length = queries[i,1] - queries[i,0] + 1;
            int[] firstArray = arr.Skip(queries[i, 0]).Take(length).ToArray();
            int min =  (from val in firstArray
                        where queries[i, 2] < val
                        select val)
                        .DefaultIfEmpty(-1)
                        .Min();
            answer[i] = min;
        }
        return answer;
    }
}