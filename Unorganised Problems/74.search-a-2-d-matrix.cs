/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */

// @lc code=start
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows=matrix.Length;
        int cols=matrix[0].Length;
        int low=0,high=rows*cols-1;
        int mid=0;
        while(low<=high){
            mid=(low+high)/2;
            if(matrix[mid/cols][mid%cols]>target){
                high=mid-1;
            }else if(matrix[mid/cols][mid%cols]<target){
                low=mid+1;
            }
            else{
                return true;
            }
        }
        return false;
        
        
        // int rows=matrix.Length;
        // int cols=matrix[0].Length;
        // int targetRow=0;
        // int low=0,high=rows-1;
        // int mid=0;
        // while(low<=high){
        //     mid=(low+high)/2;
        //     if(matrix[mid][0]>target){
        //         high=mid-1;
        //     }else if(matrix[mid][0]<target){
        //         low=mid+1;
        //     }
        //     else{
        //         return true;
        //     }
        // }

        // if(matrix[mid][0]>target){
        //     targetRow=mid-1;              
        // }else if(matrix[mid][0]<target){
        //     targetRow=mid;
        // }

        // if(targetRow<0) return false;

        // low=0;high=cols-1;mid=0;
        // while(low<=high){
        //     mid=(low+high)/2;
        //     if(matrix[targetRow][mid]>target){
        //         high=mid-1;
        //     }else if(matrix[targetRow][mid]<target){
        //         low=mid+1;
        //     }
        //     else{
        //         return true;
        //     }
        // }
        // return false;
    }
}
// @lc code=end

