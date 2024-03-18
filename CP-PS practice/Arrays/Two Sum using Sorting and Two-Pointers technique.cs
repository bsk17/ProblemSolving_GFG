/*Given an array A[] of n numbers and another number x,
the task is to check whether or not there exist two elements in A[] whose sum is exactly x.*/

/* One approach is solving by using nested loop and comparing sum of each element*/

/* Second approach is to sort the array first and then use 2 pointers starting from left and right and compare the sums of these 2 pointers.
The idea is to use the two-pointer technique. But for using the two-pointer technique, the array must be sorted. Once the array is sorted the two pointers can be taken which mark the beginning and end of the array respectively. If the sum is greater than the sum of those two elements, shift the right pointer to decrease the value of the required sum and if the sum is lesser than the required value, shift the left pointer to increase the value of the required sum.*/

using System;
using System.Collections;

public class HelloWorld
{
    static bool hasArrayTwoCandidates(int[] A, int arr_size,
                                      int sum)
    {
        int l, r;

        /* Sort the elements */
        Array.Sort(A);

        /* Now look for the two candidates
        in the sorted array*/
        l = 0;
        r = arr_size - 1;
        while (l < r) {
            if (A[l] + A[r] == sum)
                return true;
            else if (A[l] + A[r] < sum)
                l++;
            else // A[i] + A[j] > sum
                r--;
        }
        return false;
    }
    public static void Main(string[] args)
    {
       int[] A = { 1, 4, 45, 6, 10, -8 };
        int n = 16;
        int arr_size = 6;

        if (hasArrayTwoCandidates(A, arr_size, n))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}