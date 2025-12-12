// Last updated: 12/11/2025, 8:01:40 PM
public class Solution {
    public string DecodeString(string s) {
        Stack<string> stack = new Stack<string>();
        StringBuilder result = new StringBuilder();
        StringBuilder substr = new StringBuilder();
        int num = 0;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == ']')
            {
                while(stack.Peek() != "[")
                {
                    substr.Insert(0, stack.Pop());
                }
                stack.Pop(); // Popping '['
                num = int.Parse(stack.Pop());
                substr = Repeat(substr.ToString(), num);
                stack.Push(substr.ToString());
                substr.Clear();
            }
            else
            {
                if(Char.IsDigit(s[i]))
                {
                    while(Char.IsDigit(s[i]))
                    {
                        substr.Append(s[i]);
                        i++;
                    }
                    i--;    //Decrementing by 1 as for loop will also increment the variable i by 1.
                    stack.Push(substr.ToString());
                    substr.Clear();
                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }
        }
        while(stack.Count > 0)
        {
            result.Insert(0, stack.Pop());
        }
        return result.ToString();
    }
    private StringBuilder Repeat(string substr, int num)
    {
        StringBuilder result = new();
        for(int j=0; j<num; j++)
        {
            result.Append(substr);
        }
        return result;
    }

}