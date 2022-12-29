/*
 * @lc app=leetcode id=785 lang=java
 *
 * [785] Is Graph Bipartite?
 */

// @lc code=start
class Solution {
    public boolean isBipartite(int[][] graph) {
        char setArrangement[]=new char[graph.length]; 
        Arrays.fill(setArrangement,'N');
        for(int i=0;i<graph.length;i++){
            if(setArrangement[i]=='N'){
                if(!bfs(i,graph,setArrangement)) return false;
            }
        }
        return true;
    }

    public boolean bfs(int vertex,int[][] graph,char[] setArrangement){
        Queue<Integer> q=new LinkedList<Integer>();
        setArrangement[vertex]='A';
        q.add(vertex);
        do{
            vertex=q.poll();
            char currentSet=setArrangement[vertex];
            for(int i=0;i<graph[vertex].length;i++){
                int child=graph[vertex][i];
                if(setArrangement[child]!='N'&& setArrangement[child]==currentSet) return false;
                if(setArrangement[child]!='N') continue;
                q.add(child);    
                if(currentSet=='A') setArrangement[child]='B';
                else if(currentSet=='B') setArrangement[child]='A';
            }
        }while(!q.isEmpty());
        return true;

    }

}
// @lc code=end

