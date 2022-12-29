/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum=nums[0];
        int currentSum=nums[0];
        for(int i=1;i<nums.Length;i++)
        {
            if(currentSum<=0) currentSum=0;
            currentSum+=nums[i];
            maxSum=Math.Max(currentSum,maxSum);
        }
        return maxSum;
    }
}
// @lc code=end

