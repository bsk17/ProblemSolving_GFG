/*
Given a set of non-overlapping intervals and a new interval, insert the interval at correct position. If the insertion results in overlapping intervals, then merge the overlapping intervals. Assume that the set of non-overlapping intervals is sorted on the basis of start time, to find the correct position of insertion.

Prerequisite: Merge the intervals

Examples: 

Input: Set : [1, 3], [6, 9]
New Interval : [2, 5]
Output: [1, 5], [6, 9]
Explanation: The correct position to insert a new interval [2, 5] is between the two given intervals.
The resulting set would have been [1, 3], [2, 5], [6, 9], but the intervals [1, 3], [2, 5] are overlapping. So, they are merged in one interval [1, 5].

Input: Set : [1, 2], [3, 5], [6, 7], [8, 10], [12, 16]
New Interval : [4, 9]
Output: [1, 2], [3, 10], [12, 16]
Explanation: First the interval is inserted between intervals [3, 5] and [6, 7]. Then overlapping intervals are merged together in one interval.
*/

//NOT WORKED ON THIS PROBLEM