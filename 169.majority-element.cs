/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums) {
            if (count == 0) {
                candidate = num;
            }
            if(num==candidate)
            count += 1; 
            else count -= 1; 
        }

        return candidate;
    }
}
// @lc code=end

