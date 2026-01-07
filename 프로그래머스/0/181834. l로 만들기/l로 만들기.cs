using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public string solution(string myString) {
        return new string(myString.Select(val => val.CompareTo('l') < 0 ? val = 'l' : val).ToArray());
    }
}