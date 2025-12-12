// Last updated: 12/11/2025, 8:02:31 PM
public class Solution {
    public string ConvertToTitle(int columnNumber) {
        
        int remainder =0;
        Stack<char> stack = new();
        while(columnNumber > 0)
        {
            columnNumber--;
            remainder = columnNumber % 26;
            stack.Push((char)('A' + remainder));
            columnNumber /= 26;
        }
        return new string(stack.ToArray());
    }
}