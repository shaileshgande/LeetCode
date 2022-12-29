/*
 * @lc app=leetcode id=114 lang=csharp
 *
 * [114] Flatten Binary Tree to Linked List
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
    public void Flatten(TreeNode root) {
        PreOrder(root,null);
    }

    public TreeNode PreOrder(TreeNode current,TreeNode prev){
        if(current==null)
            return null;
        
        TreeNode actualLeft=current.left;
        TreeNode actualRight=current.right;
        if(prev!=null){
            prev.right=current;
            prev.left=null;
        }

        TreeNode left=PreOrder(actualLeft,current);
        TreeNode right=PreOrder(actualRight,left??current);

        return right??left??current;

    }
}
// @lc code=end

