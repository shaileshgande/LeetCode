/*
 * @lc app=leetcode id=229 lang=csharp
 *
 * [229] Majority Element II
 */

// @lc code=start
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        foreach(int number in nums){
            int value=0;
            if(!dict.TryGetValue(number,out value)){
                dict.Add(number,1);
            }
            else{
                dict[number]=++value;
            }
        }
        return dict.Where(x=>x.Value > Math.Floor(nums.Length/3.0)).Select(y=>y.Key).ToList();
    }
}
// @lc code=end

