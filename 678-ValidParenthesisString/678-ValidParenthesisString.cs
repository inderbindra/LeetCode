// Last updated: 12/11/2025, 8:00:53 PM
public class Solution {
    public bool CheckValidString(string s) {
        Stack<int> brackets = new();
        Stack<int> astrics = new();

        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == ')')
            {
                if(brackets.Count > 0)
                {
                    brackets.Pop();
                }
                else if(astrics.Count > 0)
                {
                    astrics.Pop();
                }
                else
                {
                    return false;
                }
            }
            else if(s[i] == '(')
            {
                brackets.Push(i);
            }
            else 
            {
                astrics.Push(i);
            }
        }
        while(brackets.Count > 0)
        {
            if(astrics.Count == 0 || astrics.Peek() < brackets.Peek())
            {
                return false;
            }
            brackets.Pop();
            astrics.Pop();
        }
        return true;
    }
}