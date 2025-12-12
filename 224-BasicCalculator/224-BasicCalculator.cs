// Last updated: 12/11/2025, 8:02:10 PM
public class Solution {
    public int Calculate(string s) {
        int result = 0, sign = 1, num=0;
        Stack<(int result, int sign)> stack = new();

        for(int i=0; i<s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                num = (num * 10) + s[i] - '0';
            }

            if(s[i] == '+' || s[i] == '-')
            {
                result += (sign * num);
                sign = (s[i] == '-')? -1 : 1;
                num = 0;
            }

            if(s[i] == '(')
            {
                stack.Push((result, sign));
                result = 0;
                sign = 1;
                num = 0;
            }

            if(s[i] == ')')
            {
                result += (sign * num);
                (int result, int sign) previous = stack.Pop();
                result = previous.result + (previous.sign * result);
                sign = 1;
                num = 0;
            }
        }
        result += (sign * num);
        return result;
    }
}