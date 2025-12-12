// Last updated: 12/11/2025, 8:02:34 PM
public class MinStack {
    int minValue;
    Stack<(int val, int minVal)> stack;
    public MinStack() {
        minValue = int.MaxValue;
        stack = new();
    }
    
    public void Push(int val) {
        if(minValue > val)
        {
            minValue = val;
        }
        stack.Push((val, minValue));
    }
    
    public void Pop() {
        stack.Pop();
        minValue = stack.Count > 0 ? stack.Peek().minVal : int.MaxValue;
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minVal;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */