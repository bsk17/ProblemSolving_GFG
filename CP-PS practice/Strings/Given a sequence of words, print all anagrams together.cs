/*
Given an array of words, print all anagrams together. 
For example, if the given array is {“cat”, “dog”, “tac”, “god”, “act”}, then output may be “cat tac act dog god”.
*/

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class GFG{
    private static void printAnagrams(string[] wordArray){
        Dictionary<string, List<string>> wordMap = new Dictionary<string, List<string>>();
        
        for(int i = 0; i < wordArray.Length; i++){
            string word = wordArray[i];
            char[] wordLetters = word.ToCharArray();
            Array.Sort(wordLetters);
            string newWord = new string(wordLetters);
            
            if(wordMap.ContainsKey(newWord)){
                wordMap[newWord].Add(word);
            }
            else{
                List<string> words = new List<string>();
                words.Add(word);
                wordMap.Add(newWord, words);
            }
        }
        
        foreach(KeyValuePair<string, List<string>> pair in wordMap){
            if(pair.Value.Count > 1){
                foreach(String word in pair.Value){
                    Console.Write(word + " ");
                }
            }
        }
    }
    
    public static void Main(String[] args){
        string[] wordArray = {"cat", "dog", "tac", "god", "act"};
        printAnagrams(wordArray);
    }
}