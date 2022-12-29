/*
 * @lc app=leetcode id=242 lang=java
 *
 * [242] Valid Anagram
 */

// @lc code=start
class Solution {
    public boolean isAnagram(String s, String t) {
        HashMap<Character,Integer> hm=new HashMap<Character,Integer>();
        if(s.length()!=t.length()) return false;
        for(int i=0;i<s.length();i++){
            int key=0;
            if(hm.containsKey(s.charAt(i))) key=hm.get(s.charAt(i));
            hm.put(s.charAt(i),++key);
        }
        for(int i=0;i<t.length();i++){
            if(!hm.containsKey(t.charAt(i))) return false;
            int key=hm.get(t.charAt(i));
            if(key==1) hm.remove(t.charAt(i));
            else hm.put(t.charAt(i),--key);
        }
        if(hm.size()>0) return false;
        return true;
    }
}
// @lc code=end

