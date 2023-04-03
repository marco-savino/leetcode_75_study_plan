/*
    Given an array of integers nums, calculate the pivot index of this array.

The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

Return the leftmost pivot index. If no such index exists, return -1.
*/

// trying to optimize... (wip)

public class Solution02b {
    public int PivotIndex(int[] nums) {
        
        int leftSum = 0;
        int rightSum = 0;
        int pivot = 0;

        if(nums == null)
            return -1;

        if(nums.Length == 1)
            return 0;

        for(int j=1; j<nums.Length; j++)
            rightSum = rightSum + nums[j];

        if(leftSum == rightSum)
            return pivot;

        for(pivot=1; pivot<nums.Length-1; pivot++)
        {
            leftSum = leftSum + nums[pivot-1];
            rightSum = rightSum - nums[pivot+1];

            if(leftSum == rightSum)
                return pivot;   
        }

        return -1;
    }
}

/*
ragionamenti:

nums = NULL ==> return -1
nums = [0] ==> return 0

pivot



*/