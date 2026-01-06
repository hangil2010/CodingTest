using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        
        int[] solArray = new int[] {a, b, c, d};
        
        var dupeList = (from num in solArray select num).Distinct();
        
        var dupeValueList = solArray.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key);
        
        int lengthDiff = 4 - dupeList.Count();
        
        switch(lengthDiff)
        {
            case 3:
                answer = 1111 * dupeList.ToArray()[0];
                break;
            case 2:
                if(dupeValueList.Count() == 2)
                {
                    int[] pq = dupeValueList.ToArray();
                    answer = (pq[0] + pq[1]) * Math.Abs(pq[0] - pq[1]);
                }
                else
                {
                    int distinctValue = dupeList.Where(x => x != dupeValueList.ToArray()[0]).ToArray()[0];
                    answer = (int)Math.Pow((10 * dupeValueList.ToArray()[0] + distinctValue),2);
                }
                break;
            case 1:
                var nonDupeArray = dupeList.Where(x => x != dupeValueList.ToArray()[0]).ToArray();
                answer = nonDupeArray[0] * nonDupeArray[1];
                break;
            case 0:
                answer = dupeList.Min();
                break;
        }
        
        return answer;
    }
}