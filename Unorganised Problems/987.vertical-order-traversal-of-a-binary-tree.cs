/*
 * @lc app=leetcode id=987 lang=csharp
 *
 * [987] Vertical Order Traversal of a Binary Tree
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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        List<TreeNodeWithPosition> ListWithPositions=new List<TreeNodeWithPosition>();
        Inorder(root,0,0,ListWithPositions);
        ListWithPositions.Sort((a,b)=>{
            int yaxisCompare=a.yaxis.CompareTo(b.yaxis);
            int xaxisCompare=a.xaxis.CompareTo(b.xaxis);
            if(yaxisCompare==0){
                if(xaxisCompare==0){
                    return a.node.val.CompareTo(b.node.val);
                }
                return xaxisCompare;
            }
            else
                return yaxisCompare;
        });
        IList<IList<int>> result=new List<IList<int>>();
        List<int> temp=new List<int>();
        temp.Add(ListWithPositions[0].node.val);
        int prevYaxis=ListWithPositions[0].yaxis;
        for(int i=1;i<ListWithPositions.Count;i++){
            if(ListWithPositions[i].yaxis!=prevYaxis){
                result.Add(temp);
                prevYaxis=ListWithPositions[i].yaxis;
                temp=new List<int>();
            }
            temp.Add(ListWithPositions[i].node.val);
        }
        if(temp.Count!=0) result.Add(temp);
        return result;

    }

    public void Inorder(TreeNode root,int x,int y,IList<TreeNodeWithPosition> list){
        if(root==null)
            return;
        Inorder(root.left,x+1,y-1,list);
        TreeNodeWithPosition current=new TreeNodeWithPosition(root,x,y);
        list.Add(current);
        Inorder(root.right,x+1,y+1,list);
    }
}

public class TreeNodeWithPosition {
      public int xaxis;
      public int yaxis;
      public TreeNode node;
      public TreeNodeWithPosition(TreeNode node=null, int x=0,int y=0) {
          this.xaxis = x;
          this.yaxis = y;
          this.node = node;
      }
}

// @lc code=end

