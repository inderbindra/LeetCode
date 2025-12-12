// Last updated: 12/11/2025, 8:00:22 PM
public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int mod =0, counter = 0, required=0;
        Dictionary<int, int> hashMap = new Dictionary<int, int>();

        for(int i=0; i< time.Length; i++)
        {
            mod = time[i] % 60;
            required = (mod == 0)? 0: 60-mod;

            if(hashMap.ContainsKey(required))
            {
                counter += hashMap[required];
            }

            if(hashMap.ContainsKey(mod))
            {
                hashMap[mod]++;
            }
            else
            {
                hashMap.Add(mod, 1);
            }
        }
        return counter;
    }
}