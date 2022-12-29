/*
 * @lc app=leetcode id=124 lang=csharp
 *
 * [124] Binary Tree Maximum Path Sum
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxPathSum(TreeNode root) {
        int[] result=new int[1];
        result[0]=Int32.MinValue;
        Recurse(root,result);
        return result[0];
    }

    public int Recurse(TreeNode root,int[] result){
        if(root==null) return 0;
        int leftMaxPath=Recurse(root.left,result);
        int rightMaxPath=Recurse(root.right,result);
        int curr=root.val+leftMaxPath+rightMaxPath;
        result[0]=Math.Max(result[0],curr);
        int passableToRoot=root.val+Math.Max(leftMaxPath,rightMaxPath);
        return passableToRoot>0?passableToRoot:0;
    }


}
// @lc code=end

