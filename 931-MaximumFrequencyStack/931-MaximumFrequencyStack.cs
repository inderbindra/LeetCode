// Last updated: 12/11/2025, 8:00:29 PM
public class FreqStack {
    Dictionary<int, int> numFreq;
    Dictionary<int, Stack<int>> freqWiseList;
    int maxFreq = int.MinValue;

    public FreqStack() {
        numFreq = new();
        freqWiseList = new();
    }
    
    public void Push(int val) {
        numFreq.TryAdd(val, 0);
        numFreq[val] += 1;

        freqWiseList.TryAdd(numFreq[val], new Stack<int>());
        freqWiseList[numFreq[val]].Push(val);

        maxFreq = Math.Max(maxFreq, numFreq[val]);
    }
    
    public int Pop() {
        int num = freqWiseList[maxFreq].Pop();
        numFreq[num]--;

        if(freqWiseList[maxFreq].Count == 0)
        {
            maxFreq--;
        }
        return num;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */