/*
 * @lc app=leetcode id=118 lang=csharp
 *
 * [118] Pascal's Triangle
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result=new List<IList<int>>();
        result.Add(new List<int>(){1});
        for(int i=2;i<=numRows;i++){
            int middlecol = (int)Math.Ceiling(i/2.0);
            List<int> currentList= new List<int>();
            currentList.Add(1);
            for(int j=2;j<=i-1;j++){

                if(j>middlecol)
                    currentList.Add(currentList[i-j]);
                else
                    currentList.Add(result[i-2][j-2]+result[i-2][j-1]); 
            }
            currentList.Add(1);
            result.Add(currentList);
        }
        return result;
    }
}
// @lc code=end

