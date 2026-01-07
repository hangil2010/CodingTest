using System;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        int[] first = arr.ToList().GetRange(intervals[0,0], intervals[0,1] - intervals[0,0] + 1).ToArray();
        int[] second = arr.ToList().GetRange(intervals[1,0], intervals[1,1] - intervals[1,0] + 1).ToArray();
        
        return first.Concat(second).ToArray();
    }
}