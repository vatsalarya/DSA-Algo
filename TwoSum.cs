public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        var numbers = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            if (numbers.ContainsKey(target - nums[i])){
                return new int[]{numbers[target - nums[i]], i};
            }
            else
            {
                numbers[nums[i]] = i;
            }
        }
        return [];
    }

    // If Array can be sorted
    public int[] TwoSumSort(int[] nums, int target) {
        Array.Sort(nums);

        var beginning = 0;
        var end = nums.Length-1;

        while (beginning < end)
        {
            var sum = nums[beginning] + nums[end];
            if(sum == target)
            {
                return new int[]{beginning, end};
            }
            else if (sum > target)
            {
                end--;
            }
            else
            {
                beginning++;
            }
        }
        return [];
    }
}