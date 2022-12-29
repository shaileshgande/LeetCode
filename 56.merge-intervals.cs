/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution {
    public int[][] Merge(int[][] intervals) {
        //Approach 1
        int NoOfIntervals=intervals.Length;
        int[][] positions=new int[NoOfIntervals*2][];
        int k=0;
        for(int i=0;i<NoOfIntervals;i++){
            for(int j=0;j<=1;j++){
                positions[k]=new int[2];
                positions[k][0] =intervals[i][j];
                positions[k][1]=j;
                k++;
            }
        }
        
        Array.Sort(positions, (a, b) => { return a[0]-b[0]==0?a[1]-b[1] :a[0]-b[0] ; });
        int startPosition=positions[0][0];
        int endPosition=0;
        int balance=1;
        List<List<int>> results=new List<List<int>>();
        for(int i=1;i<NoOfIntervals*2;i++)
        {
            if(positions[i][1]==0){
                balance++;
                if(balance==1) startPosition=positions[i][0];
                
            }
            else{
                balance--;
                if(balance==0) endPosition=positions[i][0];
                
            }

            if(balance==0){
                results.Add(new List<int>(){startPosition,endPosition});
            }
        }

        return results.Select(a => a.ToArray()).ToArray();

        //above solution not so optimal, there is better solution with o(nlogn) + o(n)


        // //Approach 2 - didn't finish
        // Array.Sort(intervals, (a, b) => { return a[0]-b[0]==0?a[1]-b[1] :a[0]-b[0] ; });
        // int balance=-1;
        // int NoOfIntervals=intervals.Length;
        // int startIndexPointer=0,endIndexPointer=0;
        // List<List<int>> results=new List<List<int>>();
        // while(startIndexPointer<NoOfIntervals || endIndexPointer<NoOfIntervals ){
        //     while(startIndexPointer<NoOfIntervals &&intervals[startIndexPointer][0]<=intervals[endIndexPointer][1]){
        //         startIndexPointer++;balance++;
        //     }

        //     while(endIndexPointer<NoOfIntervals && intervals[endIndexPointer+1][1]<=intervals[endIndexPointer][1]){
        //         endIndexPointer++;balance--;
        //     }
        //     if(balance==0){
        //         results.Add(new List<int>(){intervals[startIndexPointer-1][0],intervals[endIndexPointer-1][1]});
        //     }
        // }


        // return results.Select(a => a.ToArray()).ToArray();
        


    }
}
// @lc code=end

