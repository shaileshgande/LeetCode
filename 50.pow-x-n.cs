/*
 * @lc app=leetcode id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public class Solution {
    public double MyPow(double x, int n) {
        if(n==0) return 1;
        double result=1,intermediateResult=x;
        long currentExponent=1;
        long remainingExponent=n;
        remainingExponent=Math.Abs(remainingExponent);
        while(remainingExponent>0){
            while(currentExponent*2<remainingExponent){
                intermediateResult*=intermediateResult;
                currentExponent*=2;
            }
            result*=intermediateResult;
            intermediateResult=x;
            remainingExponent-=currentExponent;
            currentExponent=1;
        }

        if(n<0){
            return 1/result;
        }


        return result;
    }
}
// @lc code=end

