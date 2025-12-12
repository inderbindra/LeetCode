// Last updated: 12/11/2025, 8:01:39 PM
public class Solution {
    public int LongestPalindrome(string s) {
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        for(int i=0; i< s.Length; i++)
        {
            if(map.ContainsKey(s[i]))
            {
                map[s[i]] += 1; 
            }
            else
            {
                map.Add(s[i], 1);
            }
        }
        
        int palinSum = 0;
        foreach(var item in map)
        {
            //palinSum += (item.Value/2) * 2;
            
            if(item.Value % 2 == 0)
            {
                palinSum += item.Value;
            }
            else
            {
                palinSum += item.Value - 1;
            }
        }
        
        if(palinSum < s.Length)
        {
            palinSum += 1;
        }
        
        return palinSum;
        
        
    }
}