using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] arr, int idx) {
        return arr.ToList().FindIndex(idx, value => value == 1);
    }
}