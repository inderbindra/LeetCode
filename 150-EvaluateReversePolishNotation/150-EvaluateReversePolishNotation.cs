// Last updated: 12/11/2025, 8:02:37 PM
public class Solution {
    public int EvalRPN(string[] tokens) {
        Dictionary<string, Func<int, int, int>> hashMap = new();
        hashMap.Add("+", (n1, n2)=> { return n1 + n2;});
        hashMap.Add("-", (n1, n2)=> { return n1 - n2;});
        hashMap.Add("*", (n1, n2)=> { return n1 * n2;});
        hashMap.Add("/", (n1, n2)=> { return n1 / n2;});

        int result=0, n1=0, n2=0;
        Stack<int> stack = new();
        for(int i=0; i<tokens.Length; i++)
        {
            if(hashMap.ContainsKey(tokens[i]) && stack.Count >= 2)
            {
                n2 = stack.Pop();
                n1 = stack.Pop();
                result = hashMap[tokens[i]](n1, n2);
                stack.Push(result);
            }
            else
            {
                stack.Push(Convert.ToInt32(tokens[i]));
            }
        }
        return stack.Peek();
    }
}