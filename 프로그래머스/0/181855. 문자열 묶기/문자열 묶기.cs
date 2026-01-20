using System;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
        int[] countArray = new int[50];
        for(int i = 0 ; i < strArr.Length ; i++)
        {
            countArray[strArr[i].Length]++;
        }
        
        return countArray.Max();
    }
}