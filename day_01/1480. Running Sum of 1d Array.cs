public class Solution01 {
    public int[] RunningSum(int[] nums) {
        
        int[] res = new int[nums.Length];

        res[0] = nums[0];

        for(int i=1; i<nums.Length; i++)
            res[i] = res[i-1] + nums[i];

        return res;

    }
}

/*
ragionamenti:

res[0] = nums[0]
res[1] = nums[0] + nums[1] OR 
res[2] = nums[0] + nums[1] + nums[2] OR res[1] + nums[2]
*/