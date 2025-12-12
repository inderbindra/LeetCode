// Last updated: 12/11/2025, 8:00:48 PM
public class Solution {
    public char NextGreatestLetter(char[] letters, char target) {
        int[] asciiLetters = new int[letters.Length];

        for(int i=0; i<letters.Length; i++)
        {
            asciiLetters[i] = (int)letters[i];
        }

        if((int) target >= asciiLetters[letters.Length-1] || (int) target < asciiLetters[0])
        {
            return letters[0];
        }
        int start =1, end = letters.Length-1, mid;

        while(start< end)
        {
            mid = start + (end - start)/2;
            if(asciiLetters[mid] <= (int)target)
            {
                start = mid+1;
            }

            else if((int)target < asciiLetters[mid])
            {
                end = mid;
            }
            
        }
     
        return letters[end];
    }
}