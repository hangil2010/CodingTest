using System;
using System.Linq;
public class Solution {
    public string[] solution(string my_string) {
        return my_string.Split(' ').Where(x => x != "").Select(x => x).ToArray();
    }
}