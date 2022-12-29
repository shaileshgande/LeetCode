/*
 * @lc app=leetcode id=416 lang=csharp
 *
 * [416] Partition Equal Subset Sum
 */

// @lc code=start
public class Solution {
    public bool CanPartition(int[] nums) {
        int totalSum=0;
        totalSum=nums.Sum();
        if(totalSum%2!=0) return false;
        int[,] resultsStorage = new int[nums.Length+1,totalSum/2 +1];

        //bottom up
        for(int i=0;i<=nums.Length;i++){
            for(int j=0;j<=totalSum/2;j++){
                if(j==0) resultsStorage[i,j]=1;
                else if(i==0) resultsStorage[i,j]=-1;
                else if(nums[i-1]>j) resultsStorage[i,j]=resultsStorage[i-1,j];
                else resultsStorage[i,j]=Math.Max(resultsStorage[i-1,j-nums[i-1]],resultsStorage[i-1,j]);
            }
        }

        return resultsStorage[nums.Length,totalSum/2]==1?true:false;

        //top dowm - memoization
        //return solve(nums,0,totalSum/2,resultsStorage);
    }

    public bool solve(int[] nums,int index,int sum,int[,] storage){
        if(sum==0) return true;
        if(index>=nums.Length) return false;
        int storedValue=storage[index,sum-1];
        if(storedValue!=0) return storedValue==1?true:false; 

        if(nums[index]>sum) 
        {
            bool result= solve(nums,index+1,sum,storage);
            storage[index,sum-1]=result?1:-1;
            return result;
        }else
        {
            bool result=solve(nums,index+1,sum-nums[index],storage)||solve(nums,index+1,sum,storage);
            storage[index,sum-1]=result?1:-1;
            return result;       
        }
    }
}
// @lc code=end

