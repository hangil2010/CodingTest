using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int count = 0;
        int[] arrPlus1 = (int[])arr.Clone();
        
        while(true)
        {
            for(int i = 0 ; i < arr.Length ; i++)
            {   
                if(arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arrPlus1[i] = (int)(arr[i] / 2);
                }
                else if(arr[i] <= 50 && arr[i] % 2 == 1)
                {
                    arrPlus1[i] = (int)(arr[i] * 2) + 1;
                }
            }
            
            if(count == 5)
            {
                break;
            }
            
            bool isEqual = arr.SequenceEqual(arrPlus1);
            
            if(isEqual)
            {
                break;
            }
            else
            {
                for(int i = 0 ; i < arrPlus1.Length ; i++)
                {
                    arr[i] = arrPlus1[i];
                }
                count++;
            }
        }
        
        return count;
    }
}