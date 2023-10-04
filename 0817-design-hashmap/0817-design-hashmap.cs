public class MyHashMap {
    Dictionary<int, int> d;

    public MyHashMap() {
        d = new Dictionary<int, int>();
    }
    
    public void Put(int key, int value) {
        if(d.ContainsKey(key))  d[key] = value;
        else  d.Add(key, value);
    }
    
    public int Get(int key) {
        if(d.ContainsKey(key))  return d[key];
        else  return -1;
    }
    
    public void Remove(int key) {
        if(d.ContainsKey(key))  d.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */