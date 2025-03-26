using System;

public class Solution {
    public int solution(string before, string after) {
        char[] beforeChar = before.ToCharArray();
        Array.Sort(beforeChar);
        char[] afterChar = after.ToCharArray();
        Array.Sort(afterChar);
        for(int i = 0 ; i < beforeChar.Length ; i++){
            if(beforeChar[i] == afterChar[i]) { }
            else { return 0;}
        }
        return 1;
    }
}