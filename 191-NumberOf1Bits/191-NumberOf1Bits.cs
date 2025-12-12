// Last updated: 12/11/2025, 8:02:28 PM
public class Solution {
    public int HammingWeight(int n) {
        int counter=0;
        while(n > 0)
        {
            if(n%2 != 0)
            {
                counter++;
            }
            n = n>>1;
        }
        return counter;
    }
}