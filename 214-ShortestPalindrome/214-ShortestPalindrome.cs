// Last updated: 12/11/2025, 8:02:16 PM
public class Solution {
    int[] lps;
    public string ShortestPalindrome(string s) {
        // Step 1: Reverse the string s
        char[] c = s.ToCharArray();
        Array.Reverse(c);
        // Step 2: Create a new string and concatenate the string s, # and the reverse string.
        string t = string.Concat(s, "#", new string(c));
        //Console.WriteLine("t = " + t);
        lps = new int[t.Length];
        // Step 3: Find the Longest Prefix Suffix (Part of KMP Algo)
        FindLPS(t);
        
        // Step 4: Get the substring from string s from the index value stored in lps array last index.
        char[] temp = s.Substring(lps[t.Length-1]).ToCharArray();
        // Step 5: Reverse the new substring
        Array.Reverse(temp);
        string reverseStr = new string(temp);
        //Console.WriteLine("LPS =" + lps[t.Length-1] + " Temp = " + reverseStr + " s = " + s);
        // Step 6: Concatenate the reverseStr with String s and this will be the result.
        return string.Concat(reverseStr, s);
    }
    private void FindLPS(string t)
    {
        int i=0, j=1;
        while(j < t.Length)
        {
            if(t[i] == t[j])
            {   
                i++;
                lps[j] = i;
                j++;
            }
            else
            {
                if(i==0)
                {
                    j++;
                }
                else
                {
                    i = lps[i-1];
                }
            }
        }
    }
}