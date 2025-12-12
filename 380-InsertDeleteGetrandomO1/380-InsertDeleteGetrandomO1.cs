// Last updated: 12/11/2025, 8:01:46 PM
public class RandomizedSet {
    HashSet<int> randomSet = null;
    public RandomizedSet() {
        randomSet = new();
    }
    
    public bool Insert(int val) {
        if(randomSet.Contains(val))
        {
            return false;
        }
        randomSet.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(randomSet.Contains(val))
        {
            randomSet.Remove(val);
            return true;
        }
        return false;
    }
    
    public int GetRandom() {
        Random rand = new Random();
        return randomSet.ToList()[rand.Next(randomSet.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */