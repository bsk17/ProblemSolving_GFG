/*
Given a Queue data structure that supports standard operations like enqueue() and dequeue(). The task is to implement a Stack data structure using only instances of Queue and Queue operations allowed on the instances.
*/

/*
The idea is to keep newly entered element at the front of ‘q1’ so that pop operation dequeues from ‘q1’. ‘q2’ is used to put every new element in front of ‘q1’.

Follow the below steps to implement the push(s, x) operation: 
Enqueue x to q2.
One by one dequeue everything from q1 and enqueue to q2.
Swap the queues of q1 and q2.
Follow the below steps to implement the pop(s) operation: 
Dequeue an item from q1 and return it.
*/

/* C# Program to implement a stack using
two queue */
using System;
using System.Collections;

class GfG {

	public class Stack {
		// Two inbuilt queues
		public Queue q1 = new Queue();
		public Queue q2 = new Queue();

		public void push(int x)
		{
			// Push x first in empty q2
			q2.Enqueue(x);

			// Push all the remaining
			// elements in q1 to q2.
			while (q1.Count > 0) {
				q2.Enqueue(q1.Peek());
				q1.Dequeue();
			}

			// swap the names of two queues
			Queue q = q1;
			q1 = q2;
			q2 = q;
		}

		public void pop()
		{

			// if no elements are there in q1
			if (q1.Count == 0)
				return;
			q1.Dequeue();
		}

		public int top()
		{
			if (q1.Count == 0)
				return -1;
			return (int)q1.Peek();
		}

		public int size() { 
			return q1.Count; 
		}
	};

	// Driver code
	public static void Main(String[] args)
	{
		Stack s = new Stack();
		s.push(1);
		s.push(2);
		s.push(3);
		Console.WriteLine("current size: " + s.size());
		Console.WriteLine(s.top());
		s.pop();
		Console.WriteLine(s.top());
		s.pop();
		Console.WriteLine(s.top());
		Console.WriteLine("current size: " + s.size());
	}
}

// This code is contributed by Arnab Kundu
