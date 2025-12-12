// Last updated: 12/11/2025, 8:00:13 PM
public class Solution {
    public string RemoveDuplicates(string s, int k) {
        Stack<(char letter, int freq)> stack = new Stack<(char letter, int freq)>();
        int i=0;
        StringBuilder str = new StringBuilder();
        for(i=0; i<s.Length; i++)
        {
            if(stack.Count > 0 && stack.Peek().letter == s[i])
            {
                var item = stack.Pop();
                item.freq +=1;
                stack.Push(item);
            }
            else
            {
                stack.Push((s[i], 1));
            }
            if(stack.Count > 0 && stack.Peek().freq == k)
            {
                stack.Pop();
            }
        }
        while(stack.Count > 0)
        {   
            var item = stack.Pop();
            str.Insert(0, item.letter.ToString(), item.freq);
        }
        return str.ToString();
    }
}