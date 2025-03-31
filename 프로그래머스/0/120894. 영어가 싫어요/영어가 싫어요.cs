using System;

public class Solution {
    public long solution(string numbers) {
        string[] numberArray = new string[10] {"zero","one","two","three","four","five","six","seven","eight","nine"};
        long answer = 0;
        for(int i = 0 ; i < numberArray.Length ; i++){
            numbers = numbers.Replace(numberArray[i], i.ToString());
        }
        return long.Parse(numbers);
    }
}