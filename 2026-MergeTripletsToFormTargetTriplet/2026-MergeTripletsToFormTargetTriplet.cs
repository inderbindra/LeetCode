// Last updated: 12/11/2025, 7:59:53 PM
public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        bool result = false;
        int[] triplet = new int[3];
        for(int i=0; i<triplets.Length; i++)
        {
            if(target[0] >= triplets[i][0] && target[1] >= triplets[i][1] && target[2] >= triplets[i][2])
            {
                triplet[0] = Math.Max(triplet[0], triplets[i][0]);
                triplet[1] = Math.Max(triplet[1], triplets[i][1]);
                triplet[2] = Math.Max(triplet[2], triplets[i][2]);

                if(triplet[0] == target[0] && triplet[1] == target[1] && triplet[2] == target[2])
                {
                    return true;
                }
            }
        }
        return false;
    }
}