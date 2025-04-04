using System;

public class Solution {
    public void Swap(int[] arr, int x, int y)
    {
        int temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
    }
    public int[] solution(int[] arr, int[,] queries) {
        for(int i = 0 ; i < queries.GetLength(0) ; i++)
        {
            Swap(arr, queries[i, 0] , queries[i, 1]);
        }
        return arr;
    }
}