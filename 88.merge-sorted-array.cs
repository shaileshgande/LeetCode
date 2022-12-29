/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nums1Pointer=m-1;
        int nums2Pointer=n-1;
        for(int i=m+n-1;i>=0;i--){   
            if(nums1Pointer<0){
                nums1[i]=nums2[nums2Pointer];
                nums2Pointer--;
                continue;
            }
            if(nums2Pointer<0 ){
                nums1[i]=nums1[nums1Pointer];
                nums1Pointer--;
                continue;
            }

            if(nums1[nums1Pointer]>nums2[nums2Pointer]){
                nums1[i]=nums1[nums1Pointer];
                nums1Pointer--;
            }else {
                nums1[i]=nums2[nums2Pointer];
                nums2Pointer--;
            }
        }
    }
}
// @lc code=end

