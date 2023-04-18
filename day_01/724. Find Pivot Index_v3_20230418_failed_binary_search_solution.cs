/*
Binary search prerequisite: the array must be ordered.
Here, the comparison happens between the sum of the elements of the array starting from left,
which should be ordered by definition (a left element will always be smaller than the right element).
However, the presence of negative numbers just make the statement above not true anymore, so the 
binary search prerequisite is no longer respected and that specific algorithm cannot be implemented correctly. 
*/

public class Solution02_3 {
    public int PivotIndex(int[] nums) 
    {
       int left=0, right=nums.Length-1, sumLeft, sumRight, mid;

       while(left <= right)
       {
            sumLeft = 0;
            sumRight = 0;

            mid = left + (right-left)/2;

            for(int i=0; i<mid; i++)
                sumLeft = sumLeft + nums[i];

            for(int i=mid+1; i<nums.Length; i++)
                sumRight = sumRight + nums[i];

            Console.WriteLine("sumLeft: {0}; sumRight: {1}", sumLeft, sumRight);

            if(sumLeft == sumRight)
                return mid;
            else if(sumLeft < sumRight)
                left = mid+1;
            else
                right = mid-1;
       }

       return -1;
    }
}
