/*
 * @lc app=leetcode id=207 lang=java
 *
 * [207] Course Schedule
 */

// @lc code=start
class Solution {
    public boolean canFinish(int numCourses, int[][] prerequisites) {
        // if(prerequisites.length > numCourses-1){
        //     return false;
        // }
        ArrayList<ArrayList<Integer>> adjList=new ArrayList<ArrayList<Integer>>(numCourses);
        for(int i=0;i<numCourses;i++){
            adjList.add(new ArrayList<Integer>());
        }

        for(int i=0;i<prerequisites.length;i++){
            adjList.get(prerequisites[i][0]).add(prerequisites[i][1]);
        } 
        boolean globalVisited[]=new boolean[numCourses];
        boolean visited[]=new boolean[numCourses];
        for(int i=0;i<numCourses;i++){
            if(globalVisited[i]==false){
                //HashSet<Integer> hs=new HashSet<Integer>();
                if(dfs(i,adjList,visited,globalVisited)==false) return false;
            }
        }
        return true;

    }

    public boolean dfs(int vertex,ArrayList<ArrayList<Integer>> adjList,boolean vis[],boolean gvis[]){
        //hs.add(vertex);
        gvis[vertex]=true;
        vis[vertex]=true;
        for(int i : adjList.get(vertex)){
            //if(hs.contains(i)) return false;
            if(vis[i]) return false;
            if(gvis[i]) continue;
            if(dfs(i,adjList,vis,gvis)==false) return false;
        }
        vis[vertex]=false;
        return true;
    }


}
// @lc code=end

