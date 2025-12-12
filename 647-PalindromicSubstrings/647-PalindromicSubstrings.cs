// Last updated: 12/11/2025, 8:00:55 PM
public class Solution {
    int palinStrs = 0;
    public int CountSubstrings(string s) {
        for(int i=0; i<s.Length; i++)
        {
            ExpandAroundCenter(s, i, i);
            ExpandAroundCenter(s, i, i+1);
        }
        return palinStrs;
    }
    private void ExpandAroundCenter(string s, int left, int right)
    {
        while(left >= 0 && right < s.Length)
        {
            if(s[left] != s[right])
            {
                return;
            }
            left--;
            right++;
            palinStrs++;
        }
    }
}