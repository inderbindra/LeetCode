// Last updated: 12/11/2025, 8:00:27 PM
public class TimeMap {
    Dictionary<string, IList<(int timestamp, string value)>> TimeKV;
    public TimeMap() {
        this.TimeKV = new();
    }
    
    public void Set(string key, string value, int timestamp) {
        this.TimeKV.TryAdd(key, new List<(int timestamp, string value)>());
        this.TimeKV[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        
        string prev = "";
        if(this.TimeKV.ContainsKey(key))
        {   
            var list = this.TimeKV[key];
            int left=0, right=list.Count-1, mid=0;
            while(left <= right)
            {
                mid = (left + right) /2;
                if(list[mid].timestamp <= timestamp)
                {
                    prev = list[mid].value;
                    left = mid +1;
                }
                else
                {
                    right = mid -1;
                }
            }
        }
        return prev;
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */