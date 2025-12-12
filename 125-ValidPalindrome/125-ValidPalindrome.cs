// Last updated: 12/11/2025, 8:02:51 PM
public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder str = new();

        for(int i=0; i<s.Length; i++)
        {
            if(char.IsLetterOrDigit(s[i]))
            {
                str.Append(char.ToLower(s[i]));
            }
        }
        int left=0, right = str.Length-1;
        while(left <= right)
        {
            if(str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}