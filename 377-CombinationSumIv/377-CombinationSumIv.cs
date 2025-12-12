// Last updated: 12/11/2025, 8:01:43 PM
public class Solution {
    
    //IList<IList<int>> uniCombinationSum4 = new List<IList<int>>();
    public int CombinationSum4(int[] nums, int target) {
        //int res = FindCombinationSum4(nums, target, new List<int>());
        
        Dictionary<int, int> dp = new Dictionary<int, int>();
        
        int res = FindCombinationSum4(nums, target, dp);
        return res;
    }
    
   /* public int FindCombinationSum4(int[] candidates, int target, IList<int> currentList)
        {
            if(target < 0)
            { 
                return 0;
            }
            if(target == 0)
            {
                int[] curr = new int[currentList.Count()];
                currentList.CopyTo(curr, 0);
                uniCombinationSum4.Add(curr);
                return uniCombinationSum4.Count();
            }

            for(int i=0; i< candidates.Length; i++)
            {
                currentList.Add(candidates[i]);
                FindCombinationSum4(candidates, target - candidates[i], currentList);
                currentList.RemoveAt(currentList.Count - 1);    
            }
            return uniCombinationSum4.Count();
        }*/
    
     public int FindCombinationSum4(int[] candidates, int target, Dictionary<int, int> dp)
        {
         int result = 0;
            if(target < 0)
            { 
                return 0;
            }
            if(target == 0)
            {
                return 1;
            }
            if(dp.ContainsKey(target))
            {
                return dp[target];
            }

            for(int i=0; i< candidates.Length; i++)
            {
                result += FindCombinationSum4(candidates, target - candidates[i], dp);
                
            }
            dp[target]= result;
            return dp[target];
        }
}