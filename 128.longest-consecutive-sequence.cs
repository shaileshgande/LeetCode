/*
 * @lc app=leetcode id=128 lang=java
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
class Solution {
    public int longestConsecutive(int[] nums) {
        HashSet<Integer> hs=new HashSet<Integer>();
        for(int i=0;i<nums.length;i++){
            hs.add(nums[i]);
        }
        int maxSequence=0;
        
        for(int i=0;i<nums.length;i++){
            if(!hs.contains(nums[i]-1)){
                int currentNumber=nums[i];
                int currentSequenceCount=1;
                while(hs.contains(++currentNumber)){
                    currentSequenceCount++;
                }
                maxSequence=Math.max(maxSequence,currentSequenceCount);
            }
        }
        return maxSequence;
    }
}
// @lc code=end

