/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution {
    public void Rotate(int[][] matrix) {
        int size=matrix.Length;
        ReverseMatrix(matrix,size);
        TransposeMatrix(matrix,size);
    }

    public void ReverseMatrix(int[][] matrix,int size){
        double halfSize=size/2.0;
        int middleRow=(int)Math.Floor(halfSize);
        for(int row=0;row<middleRow;row++){
            int oppositeRow=size-1-row;
            for(int col=0;col<size;col++){
                Swap(row,col,oppositeRow,col,matrix);
            }
        }
    }

    public void TransposeMatrix(int[][] matrix,int size){
        for(int row=0;row<size;row++){
            for(int col=row;col<size;col++){
                if(row!=col){
                    Swap(row,col,col,row,matrix);
                }
            }
        }
    }

    public void Swap(int row1,int col1,int row2,int col2,int[][] matrix){
        int temp=matrix[row1][col1];
        matrix[row1][col1]=matrix[row2][col2];
        matrix[row2][col2]=temp;
    }
}
// @lc code=end

