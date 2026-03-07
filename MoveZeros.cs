// https://leetcode.com/problems/move-zeroes/
public class Solution {
    public void MoveZeroes(int[] nums) {
        int current = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                (nums[i], nums[current]) = (nums[current], nums[i]);
                current++;
            }
        }
    }
}
