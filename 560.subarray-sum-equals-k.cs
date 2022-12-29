/*
 * @lc app=leetcode id=560 lang=java
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution {
    public int subarraySum(int[] nums, int k) {
        HashMap<Integer,Integer> hm=new HashMap<>();
        int cummulativeSum=0,result=0;
        for(int i=0;i<nums.length;i++){
            cummulativeSum+=nums[i];
            if(cummulativeSum-k==0) result++;
            if(hm.containsKey(cummulativeSum-k)){
                result+=hm.get(cummulativeSum-k);
            }
            if(hm.containsKey(cummulativeSum)){
                int key=hm.get(cummulativeSum);
                hm.put(cummulativeSum,++key);
            }
            else
                hm.put(cummulativeSum,1);
        }
        return result;
    }
}
// @lc code=end

