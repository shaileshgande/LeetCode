/*
 * @lc app=leetcode id=503 lang=java
 *
 * [503] Next Greater Element II
 */

// @lc code=start
class Solution {
    public int[] nextGreaterElements(int[] nums) {
        HashMap<Integer,Integer> hm=new HashMap<Integer,Integer>();
        Stack<Pair<Integer,Integer>> stack=new Stack<Pair<Integer,Integer>>();
        int result[]=new int[nums.length];
        stack.push(new Pair(0,nums[0]));
        int i=1;
        while (i<nums.length)
        {
            if(stack.isEmpty()){
                stack.push(new Pair(i,nums[i]));
                ++i;
                i%=nums.length;
                continue;
            }
            
            if(stack.size()>nums.length || (nums[i]==stack.peek().getValue() && i==stack.peek().getKey())){
                break;
            }
            if(nums[i]<=stack.peek().getValue()) {
                if(hm.containsKey(i)) {
                    ++i;
                    i%=nums.length;
                    continue;  
                }
                stack.push(new Pair(i,nums[i]));
                ++i;
                i%=nums.length;
            }
            else{
                hm.put(stack.pop().getKey(),nums[i]);
            }
        }

        for(int j=0;j<nums.length;j++){
            result[j]=hm.containsKey(j) ? hm.get(j) : -1;
        }
        return result;
    }
}
// @lc code=end

