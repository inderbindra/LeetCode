// Last updated: 12/11/2025, 8:02:38 PM
public class LRUCache {
    Dictionary<int, LinkedListNode<(int key, int val)>> cache;
    LinkedList<(int key, int val)> cacheList;
    int capacity;
    public LRUCache(int capacity) {
        cache = new Dictionary<int, LinkedListNode<(int key, int val)>>(capacity);
        cacheList = new();
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(cache.ContainsKey(key))
        {
            var item = cache[key];
            cacheList.Remove(item);
            cacheList.AddFirst(item);
            return item.Value.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        LinkedListNode<(int key, int val)> node = new LinkedListNode<(int, int)>((key, value));
        if(cache.ContainsKey(key))
        {
            var item = cache[key];
            cacheList.Remove(item);
            cache[key] = node;
            cacheList.AddFirst(node);
        }
        else
        {
            if(cacheList.Count == this.capacity)
            {
                cache.Remove(cacheList.Last.Value.key);
                cacheList.RemoveLast();
            }
            cache.Add(key, node);
            cacheList.AddFirst(node);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */