/*
 * @lc app=leetcode id=4 lang=java
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
class Solution {
    public double findMedianSortedArrays(int[] nums1, int[] nums2) {
        int m=nums1.length;
        int n=nums2.length;
        int medianindex=(m+n+1)/2;
        int secondMedianIndex=(m+n)%2==0?medianindex+1:medianindex;
        double median=0;
        int i=0,j=0;
        int combinedCounter=0;
        while(i<m||j<n){
            if(j>=n|| (i<m&&nums1[i]<nums2[j])){
                if(combinedCounter+1==medianindex)
                  median+=nums1[i];
                if(combinedCounter+1==secondMedianIndex){
                  median+=nums1[i];
                  break;
                }
                i++;
            }
            else{
                if(combinedCounter+1==medianindex)
                  median=nums2[j];
                if(combinedCounter+1==secondMedianIndex){
                  median+=nums2[j];
                  break;
                }
                j++;
            }
            combinedCounter++;
        }
        return median/2;
    }
}
// @lc code=end

