using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] code = letter.Split(" ");
        string[] morseCode = new string[] 
        {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---",
         "-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-",
         "..-","...-",".--","-..-","-.--","--.."};
        string[] morseToAlpha = new string[] 
        {"a","b","c","d","e","f","g","h","i","j",
         "k", "l","m","n","o","p","q","r","s","t",
         "u","v","w","x","y","z"};
        int index = 0;
        for(int i = 0 ; i < code.Length ; i++){
            index = Array.IndexOf(morseCode, code[i]);
            answer += morseToAlpha[index];
        }
        return answer;
    }
}