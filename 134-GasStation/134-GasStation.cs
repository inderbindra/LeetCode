// Last updated: 12/11/2025, 8:02:46 PM
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum())
        {
            return -1;
        }
        int total=0, result=0;
        for(int i=0; i<gas.Length; i++)               
        {
            total += gas[i] - cost[i];
            if(total < 0)
            {
                total = 0;
                result = i + 1;
            }
        }
        return result;
    }
}

