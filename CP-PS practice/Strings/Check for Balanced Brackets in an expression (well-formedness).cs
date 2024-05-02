/*
Given an expression string exp, write a program to examine whether the pairs and the orders of “{“, “}”, “(“, “)”, “[“, “]” are correct in the given expression.

nput: exp = “[()]{}{[()()]()}” 
Output: Balanced
Explanation: all the brackets are well-formed

Input: exp = “[(])” 
Output: Not Balanced 
Explanation: 1 and 4 brackets are not balanced because 
there is a closing ‘]’ before the closing ‘(‘
*/


/*
APPROACH: 1 - Check for Balanced Bracket expression without using stack 
Following are the steps to be followed:

Initialize a variable i with -1.
Iterate through the string and 
If it is an open bracket then increment the counter by 1 and replace ith character of the string with the opening bracket.
Else if it is a closing bracket of the same corresponding opening bracket (opening bracket stored in exp[i]) then decrement i by 1.
At last, if we get i = -1, then the string is balanced and we will return true. Otherwise, the function will return false.
*/
using System;

public class GFG {
	static bool areBracketsBalanced(string s) {
		int i = -1;
		char[] stack = new char[s.Length];
		foreach (char ch in s) {
			if (ch == '(' || ch == '{' || ch == '[')
				stack[++i] = ch;
			else {
				if (i >= 0 && ((stack[i] == '(' && ch == ')') || (stack[i] == '{' && ch == '}') || (stack[i] == '[' && ch == ']')))
					i--;
				else
					return false;
			}
		}
		return i == -1;
	}

	static void Main() {
		string expr = "{()}[]";

		// Function call
		if (areBracketsBalanced(expr))
			Console.WriteLine("Balanced");
		else
			Console.WriteLine("Not Balanced");
	}
}



/*
Check using Stack
*/

using System;
using System.Collections.Generic;

public class Program{
// Function to check if a given string of parentheses is balanced or not
public static bool check(string str){
        Stack<char> stack = new Stack<char>();
        for(int i=0; i<str.Length; i++){
            char ch = str[i];
            
            if(ch == '(' || ch == '{' || ch == '['){
                stack.Push(ch);
            }
            if(ch == ')' || ch == '}' || ch == ']'){
                if(stack.Count == 0){
                    return false;
                }
                
                char top = stack.Pop();
                
                if((top == '(' && ch != ')') || (top == '{' && ch != '}') ||(top == '[' && ch != ']')){
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
    public static void Main(string[] args)
    {
        string str = "()(())()[{}]";
    	if (check(str) == false){
    	    Console.WriteLine("Invalid");
    	}
    	else{
    	    Console.WriteLine("Valid");
    	}
    }
}
