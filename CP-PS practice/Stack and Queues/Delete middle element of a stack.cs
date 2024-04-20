/*
Given a stack with push(), pop(), and empty() operations, The task is to delete the middle element of it without using any additional data structure.

Input  : Stack[] = [1, 2, 3, 4, 5]
Output : Stack[] = [1, 2, 4, 5]

Input  : Stack[] = [1, 2, 3, 4, 5, 6]
Output : Stack[] = [1, 2, 4, 5, 6]
*/

/*
Pop the elements above the middle element of the given stack and use a temp stack to store these popped elements. Then pop the middle element and push the elements of the temp stack in the given stack.
*/

// C# code to delete middle of a stack
// without using additional data structure.
using System;
using System.Collections.Generic;

class GFG {

static void deleteMid(Stack<char> st,int n)
{
	Stack<char> tempStack = new Stack<char>();
	int count = 0;
	
	while(count < n/2){
		char c = st.Peek();
		st.Pop();
		tempStack.Push(c);
		count++;
	}
	
	//Middle Element is popped now
	//This can aslo be used to print in case required
	st.Pop();
	
	while(tempStack.Count != 0){
		st.Push(tempStack.Peek());
		tempStack.Pop();
	}
}

// Driver Code
public static void Main() 
{
	Stack<char> st = new Stack<char>();

	// push elements into the stack
	st.Push('1');
	st.Push('2');
	st.Push('3');
	st.Push('4');
	st.Push('5');
	st.Push('6');
	st.Push('7');

	deleteMid(st, st.Count);

	// Printing stack after 
	// deletion of middle.
	while (st.Count != 0)
	{
	char p=st.Peek();
	st.Pop();
	Console.Write(p + " ");
	}
}
}

// This code is contributed by utkarshshriode02.


// This code is contributed by utkarshshriode02.
