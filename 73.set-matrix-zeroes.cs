/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 */

// @lc code=start
public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rows=matrix.Length;
        bool fillFirstRowWithZeros=false;
        bool fillFirstColWithZeros=false;
        int cols=matrix[0].Length;

        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(matrix[i][j]==0){
                    if(i==0) fillFirstRowWithZeros=true;
                    if(j==0) fillFirstColWithZeros=true;
                    if(i==0||j==0) continue;
                    matrix[i][0]=0;
                    matrix[0][j]=0;
                }
            }
        }

        for(int i=1;i<rows;i++){
            for(int j=1;j<cols;j++){
                if(matrix[i][0]==0 || matrix[0][j]==0){
                    matrix[i][j]=0;
                }
            }
        }

        if(fillFirstColWithZeros){
            for(int i=0;i<rows;i++){
                matrix[i][0]=0;          
            }
        }

        if(fillFirstRowWithZeros){
            for(int i=0;i<cols;i++){
                matrix[0][i]=0;
            }
        }
    }
}
// @lc code=end

