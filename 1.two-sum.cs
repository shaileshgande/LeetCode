/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result=new int[2];
        HashSet<int> numsHash = new HashSet<int>();
        numsHash.Add(nums[0]);
        int i=0;
        for(i=1;i<nums.Length;i++){
            if(numsHash.Contains(target-nums[i])){
                result[0]=i;
                break;
            }
            numsHash.Add(nums[i]);
        }

        for(int j=0;j<=i;j++){
            if(nums[j]==target-nums[i]){ 
                result[1]=j;
                break;
            }
        }
        return result;

    }
}
// @lc code=end

