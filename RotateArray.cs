using System;

public class Solution
{
    /*
     * ============================================
     * 1. Most Optimal: Reverse Method
     * Time: O(n)
     * Space: O(1)
     * ============================================
     */
    public void Rotate(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return;

        int n = nums.Length;
        k = k % n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }

    /*
     * ============================================
     * 2. Optimal with Extra Array
     * Time: O(n)
     * Space: O(n)
     * ============================================
     */
    public void RotateWithExtraArray(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return;

        int n = nums.Length;
        k = k % n;

        int[] temp = new int[n];

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + k) % n;
            temp[newIndex] = nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = temp[i];
        }
    }

    /*
     * ============================================
     * 3. Brute Force (Shift One Step at a Time)
     * Time: O(n × k)
     * Space: O(1)
     * ============================================
     */
    public void RotateBruteForce(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0)
            return;

        int n = nums.Length;
        k = k % n;

        for (int i = 0; i < k; i++)
        {
            int last = nums[n - 1];

            for (int j = n - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = last;
        }
    }
}