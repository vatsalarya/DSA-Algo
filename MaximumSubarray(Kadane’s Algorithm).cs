public class Solution {

    // Kadane’s Algorithm: “Is it better to extend the previous subarray, or start fresh from here?”. That’s it.
    // Instead of checking all O(n²) subarrays like brute force, we track:
        // currentSum → best subarray ending at this index
        // maxSum → best subarray seen so far
    public int MaxSubArray(int[] nums) {
        var maxSum = int.MinValue;
        var currentSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum=0;
            }
            currentSum += nums[i];
            if(currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        return maxSum;

        // AI version of same algo:
        // int currentSum = nums[0];
        // int maxSum = nums[0];

        // for (int i = 1; i < nums.Length; i++)
        // {
        //     currentSum = Math.Max(nums[i], currentSum + nums[i]);
        //     maxSum = Math.Max(maxSum, currentSum);
        // }
    }
    
    // Brute force O(n²):
    public int MaxSubArrayBrute(int[] nums) {
        var maxSum = int.MinValue;
        for(int i=0;i< nums.Length; i++)
        {
            var currentSum = 0;
            for(int j=i; j<nums.Length; j++)
            {
                currentSum+=nums[j];
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }
}