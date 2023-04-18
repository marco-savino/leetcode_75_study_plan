public class Solution02_4 {
    public int PivotIndex(int[] nums) 
    {
        int sumLeft = 0, sumRight = 0;

        for(int i=0; i<nums.Length; i++)
            sumRight = sumRight + nums[i];

        for(int i=0; i<nums.Length; i++)
        {
            sumRight = sumRight - nums[i];

            //Console.WriteLine("sumLeft: {0}; sumRight: {1}", sumLeft, sumRight);
            if(sumLeft == sumRight)
                return i;

            sumLeft = sumLeft + nums[i];
        } 

        return -1;
    }
}
