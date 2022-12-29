/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start
public class Solution {
    public int UniquePaths(int m, int n) {
        m--;
        n--;
        int totalMoves=m+n;
        double numerator=1;
        double denominator=1;
        int lesservalue=m>n?n:m;
        for(int i=totalMoves;i>totalMoves-lesservalue;i--){
            numerator*=i;
            denominator*=i-totalMoves+lesservalue;
        }

        return (int)(numerator/denominator);
    }
}
// @lc code=end

