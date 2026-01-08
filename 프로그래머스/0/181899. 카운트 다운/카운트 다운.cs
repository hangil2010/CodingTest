using System;
using System.Linq;
public class Solution {
    public int[] solution(int start_num, int end_num) {
        return Enumerable.Range(0, start_num - end_num + 1).Select(i => start_num - i).ToArray();
    }
}