/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution {
    public void NextPermutation(int[] nums) {
        bool lastPermutation=true;
        for(int i=nums.Length-2;i>=0;i--){
            if(nums[i]>=nums[i+1])
                continue;
            else
            {
                lastPermutation=false;
                SwapElementWithNextGreatestElementInTheSubarray(i,nums,i+1);
                break;
            }
            
        }
        if(lastPermutation)
            SortSubArray(nums,0);
    }

    public void SwapElementWithNextGreatestElementInTheSubarray(int index,int[] nums,int startIndexOfSubArray){
        SortSubArray(nums,startIndexOfSubArray);
        int element=nums[index];
        for(int i=startIndexOfSubArray;i<nums.Length;i++){
            if(nums[i]>element){
                int temp=nums[index];
                nums[index]=nums[i];
                nums[i]=temp;
                break;
            }
        }
    }

    public void SortSubArray(int[] nums,int startIndexOfSubArray){
        for(int i=startIndexOfSubArray,j=nums.Length-1;i<nums.Length;i++,j--){
            if(i>=j){
                break;
            }
            int temp=nums[i];
            nums[i]=nums[j];
            nums[j]=temp;
        }
    }
}
// @lc code=end

