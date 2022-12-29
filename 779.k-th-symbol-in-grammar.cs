/*
 * @lc app=leetcode id=779 lang=java
 *
 * [779] K-th Symbol in Grammar
 */

// @lc code=start
class Solution {
    public int kthGrammar(int n, int k) {
        //base condition
        if(n==1&&k==1){
            return 0;
        }
        //hypothesis
        int prev=kthGrammar(/*Induction*/n-1,(k+1)/2);
        return /*Induction*/(prev^(k%2))==0?1:0;   

        //leetcode solution page has O(1) solution.    
    }
}
// @lc code=end

