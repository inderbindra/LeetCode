// Last updated: 12/11/2025, 8:02:08 PM
public class Solution {
    public int Calculate(string s) {
        int num=0, result=0;
        char oper = '+';
        Stack<int> stack = new();
        for(int i=0; i<s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                num = (num * 10) + (s[i] - '0');
            }
            if((!char.IsDigit(s[i]) && s[i] != ' ') || i == s.Length-1)
            {
                if(oper == '+')
                {
                    stack.Push(num);
                }
                else if(oper == '-')
                {
                    stack.Push(-num);
                }
                else if(oper == '*')
                {
                    stack.Push(stack.Pop() * num);
                }
                else if (oper == '/')
                {
                    stack.Push(stack.Pop() / num);
                }
                num = 0;
                //Assign current operator
                oper = s[i];
            }
        }
        while(stack.Count > 0)
        {
            result += stack.Pop();
        }
        return result;
    }
}