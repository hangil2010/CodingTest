using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] word = new string[4] {"aya","ma","woo","ye"};
        int answer = 0;
        int number;
        for(int i = 0 ; i < word.Length ; i++)
        {
            for(int j = 0 ; j < babbling.Length ; j++)
            {
                babbling[j] = babbling[j].Replace(word[i], "1");
            }
        }
        for(int i = 0 ; i < babbling.Length ; i++)
        {
            bool sucess = int.TryParse(babbling[i], out number);
            if(sucess) answer++;
        }
        return answer;
    }
}