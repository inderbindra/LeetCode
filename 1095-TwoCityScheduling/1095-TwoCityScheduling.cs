// Last updated: 12/11/2025, 8:00:24 PM
public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        int[] cityB = new int[costs.Length];
        int i=0, totalCost = 0;
        for(i=0; i<costs.Length; i++)
        {
            totalCost += costs[i][0];
            cityB[i] = costs[i][1] - costs[i][0];
        }
        Array.Sort(cityB);
        for(i =0; i<costs.Length/2; i++)
        {
            totalCost += cityB[i];
        }
        return totalCost;
    }
}