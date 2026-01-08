using System;
using System.Linq;
public class Solution {
    public int[] solution(int n, int k) {
        return Enumerable.Range(0, (int)(n/k)).Select(i => k * (i + 1)).ToArray();
    }
}