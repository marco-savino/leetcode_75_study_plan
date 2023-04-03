/*
    Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.
*/

// this works!
public class Solution02 {
    public int PivotIndex(int[] nums) {
        
        int leftSum = 0;
        int rightSum = 0;

        if(nums == null)
            return -1;

        if(nums.Length == 1)
            return 0;

        for(int pivot=0; pivot<nums.Length; pivot++)
        {
            rightSum = 0;

            if(pivot != 0)
                leftSum = leftSum + nums[pivot-1];
            
            for(int j=pivot+1; j<nums.Length; j++)
                rightSum = rightSum + nums[j];

            if(leftSum == rightSum)
                return pivot;
        }

        return -1;

    }
}