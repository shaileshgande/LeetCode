/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int maxprofit=0;
        int min=prices[0];
        for(int i=1;i<prices.Length;i++){
            int difference=prices[i]-min;
            if(maxprofit<difference){
                maxprofit=difference;
            }
            if(prices[i]<min)
                min=prices[i];
        }
        return maxprofit;
    }
}
// @lc code=end

