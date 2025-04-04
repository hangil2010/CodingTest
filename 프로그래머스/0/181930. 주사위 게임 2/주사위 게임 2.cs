using System;
public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        switch(CompareNum(a, b, c))
        {
            case 1:
                answer = (a + b + c) * 
                         (int)(Math.Pow(a, 2)+Math.Pow(b, 2)+Math.Pow(c, 2)) *
                         (int)(Math.Pow(a, 3)+Math.Pow(b, 3)+Math.Pow(c, 3));
                break;
            case 2:
                answer = (a + b + c) * 
                         (int)(Math.Pow(a, 2)+Math.Pow(b, 2)+Math.Pow(c, 2));
                break;
            case 3:
                answer = (a + b + c);
                break;
        }
        return answer;
    }
    
    public int CompareNum(int a, int b, int c)
    {
        if(a == b)
        {
            if (b == c) // a == b
            {
                return 1;
            }
            else // a == b, b != c 
            {
                return 2;
            }
        }
        else if (b == c) // a != b
        {
            return 2;
        }
        else if (a == c) // a != b && b != c
        {
            return 2;
        }
        else // a != b && b != c && a != c
        {
            return 3;
        }
    }
}