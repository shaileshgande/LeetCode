/*
 * @lc app=leetcode id=496 lang=java
 *
 * [496] Next Greater Element I
 */

// @lc code=start
class Solution {
    public int[] nextGreaterElement(int[] nums1, int[] nums2) {
        HashMap<Integer,Integer> hm=new HashMap<Integer,Integer>();
        Stack<Integer> stack=new Stack<Integer>();
        int result[]=new int[nums1.length];
        stack.push(nums2[0]);
        for(int i=1;i<nums2.length;){
            if(stack.isEmpty()){
                stack.push(nums2[i]);
                i++;
                continue;
            }

            if(nums2[i]<stack.peek()) {
                stack.push(nums2[i]);
                i++;
            }
            else{
                hm.put(stack.pop(),nums2[i]);
            }
        }

        for(int i=0;i<nums1.length;i++){
            result[i]=hm.containsKey(nums1[i]) ? hm.get(nums1[i]) : -1;
        }
        return result;
    }
}
// @lc code=end

