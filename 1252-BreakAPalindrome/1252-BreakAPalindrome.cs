// Last updated: 12/11/2025, 8:00:19 PM
public class Solution {
    public string BreakPalindrome(string palindrome) {
        int i=0, length = palindrome.Length;

        if(length == 1) return "";
        
        char[] res = new char[length];
        res = palindrome.ToCharArray();
        
        
        for(i=0; i<(length)/2; i++)
        {
            if(palindrome[i] != 'a')
            {
                res[i] =  'a';
                return new string(res);
            }
        }
        
        res[length-1] = 'b';
        return new string(res);
    }
}