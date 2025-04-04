using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string polynomial) {
        int xVal = 0;
        string x = "";
        string ad = "";
        string con = "";
        int constVal = 0;
        string[] poly = polynomial.Split(" ");
        foreach(string str in poly)
        {
            Console.Write($"{str}");
        }
        for(int i = 0 ; i < poly.Length ; i++)
        {
            if(poly[i].Contains("x"))
            {
                string pol = poly[i].Substring(0, poly[i].Length - 1);
                if(pol.Length == 0)
                {
                    xVal++;
                }
                else
                {
                    xVal += int.Parse(pol);
                }
            }
            else if(poly[i] == "+")
            {
                continue;
            }
            else
            {
                constVal += int.Parse(poly[i]);
            }
        }
        if(xVal == 1){
            x = "x";
        }
        else if (xVal > 1)
        {
            x = $"{xVal}x";
        }
        if(xVal > 0 && constVal > 0){
            ad = " + ";
        }
        if(constVal > 0)
        {
            con = $"{constVal}";
        }
        string answer =$"{x}{ad}{con}";
        return answer;
    }
}