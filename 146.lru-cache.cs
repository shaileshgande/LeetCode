/*
 * @lc app=leetcode id=146 lang=java
 *
 * [146] LRU Cache
 */

// @lc code=start
class LRUCache {
    HashMap<Integer,Node> hm;
    Node head=new Node(-1,-1);
    Node tail=new Node(-1,-1);
    int capacity;
    public LRUCache(int _capacity) {
        hm=new HashMap<Integer,Node>(capacity);
        head.next=tail;
        tail.prev=head;
        capacity=_capacity;
    }
    
    public int get(int key) {
        if(!hm.containsKey(key)) return -1;
        Node node=hm.get(key);
        deleteNodeFromDLL(node);
        addNodeToHead(node);
        return node.value;
    }
    
    public void put(int key, int value) {
        if(!hm.containsKey(key) && hm.size()>=capacity){
            hm.remove(tail.prev.key);
            deleteNodeFromDLL(tail.prev);
            Node node=new Node(key,value);
            addNodeToHead(node);
            hm.put(key,node);
        }
        else if(!hm.containsKey(key)){
            Node node=new Node(key,value);
            addNodeToHead(node);
            hm.put(key,node);
        }
        else{
            Node node=hm.get(key);
            deleteNodeFromDLL(node);
            addNodeToHead(node);
            node.value=value;
        }
    }

    public void deleteNodeFromDLL(Node node){
        Node prev=node.prev;      
        prev.next=node.next;
        node.next.prev=prev;
        node.prev=null;
        node.next=null;
    }

    public void addNodeToHead(Node node){
        Node headsNextNode=head.next;
        head.next=node;
        node.next=headsNextNode;
        node.prev=head;
        headsNextNode.prev=node;
    }


    class Node{
        Node prev,next;
        int key,value;
        Node(int k,int v){
            key=k;
            value=v;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

