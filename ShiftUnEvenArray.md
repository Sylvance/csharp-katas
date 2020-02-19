# Shift Uneven Array
## Shift Uneven Array

Write a function which accepts an integer array and its size and modifies the array in the following manner:

- If the elements of index i and (i+1) are equal then, double the value at index i
and replace the element at index (i+1) with 0. 

- If the element at index i is 0, then ignore it.

- Any number (element in an array) must be modified only once.

- At the end, shift all the zeros (0s) to the right of the array and remaining
nonzeros to the left of the array.
```
Example: 
Input: 2 2 0 4 0 8
Output: 4 4 8 0 0 0

Input: 2 2 0 4 0 2
Output: 4 4 2 0 0 0
```
