// Last updated: 12/11/2025, 8:01:58 PM
public class MedianFinder {
    PriorityQueue<int, int> rightMinHeap;
    PriorityQueue<int, int> leftMaxHeap;
    public MedianFinder() {
        rightMinHeap = new();
        leftMaxHeap = new();
    }
    
    public void AddNum(int num) {
        rightMinHeap.Enqueue(num, num);
        int val = rightMinHeap.Dequeue();
        leftMaxHeap.Enqueue(val, -val);

        if(leftMaxHeap.Count > rightMinHeap.Count + 1)
        {
            val = leftMaxHeap.Dequeue();
            rightMinHeap.Enqueue(val, val);
        }
    }
    
    public double FindMedian() {
        double median=0.0;
        if(leftMaxHeap.Count > rightMinHeap.Count)
        {
            median = leftMaxHeap.Peek();
        }
        else
        {
            median = (leftMaxHeap.Peek() + rightMinHeap.Peek())/2.0;
        }
        return median;        
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */