using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] num_list, int n) {
        return num_list.ToList().Take(n).ToList().ToArray();
    }
}