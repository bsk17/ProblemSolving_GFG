/*
Given string str, we need to print the reverse of individual words.

Input : Hello World

Output : olleH dlroW
*/

/*
 We use a stack to push all words before space. As soon as we encounter a space, we empty the stack.
*/

using System;
using System.Collections.Generic;

class GFG{
	public static void reverseWords(string s){
		Stack<char> st = new Stack<char>();
		
		for(int i=0; i<s.Length; i++){
			if(s[i] != ' '){
				st.Push(s[i]);
			}
			else{
				while(st.Count > 0){
					Console.Write(st.Pop());
				}
				Console.Write(" ");
			}
		}
		
		while(st.Count > 0){
			Console.Write(st.Pop());
		}
	}
	
	public static void Main(string[] args){
		string str = "Geeks for Geeks";
		reverseWords(str);
	}
}