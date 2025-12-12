// Last updated: 12/11/2025, 8:01:41 PM
public class RandomizedCollection {
    IList<int> values = null;
    IDictionary<int, IList<int>> dict = null;
    Random rand = null;
    public RandomizedCollection() {
        values = new List<int>();
        dict = new Dictionary<int, IList<int>>();
        rand = new Random();
    }
    public bool Insert(int val) {
        bool status = dict.TryAdd(val, new List<int>());
        values.Add(val);
        dict[val].Add(val);
        return status;
    }
    public bool Remove(int val) {
        Console.WriteLine("1. val = " + val);
        if(dict.TryGetValue(val, out var list))
        {
            dict[val].Remove(val);
            if(dict[val].Count == 0)
            {
                dict.Remove(val);
            }
            values.Remove(val);
            return true;
        }
        return false;
    }
    public int GetRandom() {
        return values[rand.Next(values.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */