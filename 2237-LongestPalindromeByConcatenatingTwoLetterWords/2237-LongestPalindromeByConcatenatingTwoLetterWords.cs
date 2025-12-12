// Last updated: 12/11/2025, 7:59:47 PM
public class Solution {
    public int LongestPalindrome(string[] words) {
     
        IDictionary<string, int> map = new Dictionary<string, int>();
        
        for(int i=0; i< words.Length; i++)
        {
            if(map.ContainsKey(words[i]))
            {
                map[words[i]] +=1;
            }
            else
            {
                map.Add(words[i], 1);
            }
        }
        
        int palimLength = 0, palimStrLength =0, val;
        foreach(var item in map)
        {
            char[] array = item.Key.ToCharArray();
            Array.Reverse(array);
            string revStr = new string(array);
            val = 0;
            
            if(item.Key.Equals(revStr)) //Palimdrome string
            {
                val = item.Value;
                if(val % 2!= 0)
                {
                    val--;
                }
                palimLength += 2 * val;
            }
            else
            {
                if(map.ContainsKey(revStr))
                {
                    val = Math.Min(item.Value, map[revStr]);
                    palimLength += (4 * val);
                    
                    map[revStr] -= val;
                }
            }
            map[item.Key] = item.Value - val;
        }
        
        foreach(var item in map)
        {
            char[] array = item.Key.ToCharArray();
            Array.Reverse(array);
            string revStr = new string(array);
            val = 0;
            
            if(item.Key.Equals(revStr) && item.Value > 0) //Palimdrome string
            {
                palimLength += 2;
                break;
            }
        }
        return palimLength;
    }
}