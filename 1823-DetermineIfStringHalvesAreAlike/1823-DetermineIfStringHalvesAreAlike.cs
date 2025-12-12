// Last updated: 12/11/2025, 7:59:56 PM
public class Solution {
    public bool HalvesAreAlike(string s) {
    
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        int j = s.Length/2;
        int counter1 =0, counter2=0;
        for(int i=0; i < s.Length/2; i++)
        {
            for(int k=0; k<vowels.Length; k++)
            {
                if(s[i].Equals(vowels[k]))
                {
                    counter1++;
                }
                
                if(s[j].Equals(vowels[k]))
                {
                    counter2++;
                }
            }
            j++;
        }
        
        if(counter1 == counter2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}