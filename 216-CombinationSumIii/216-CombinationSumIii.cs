// Last updated: 12/11/2025, 8:02:13 PM
public class Solution {
    
     IList<IList<int>> uniCombinationSum3 = new List<IList<int>>();
    public IList<IList<int>> CombinationSum3(int k, int n) {
        
        FindCombinationSum3(k, n, new List<int>(), 1);
        return uniCombinationSum3;
    }
    
     public void FindCombinationSum3(int k, int n, List<int> currentList, int index)
        {
            if(n < 0)
            {
                return;
            }
            if(n == 0 && k == 0)
            {
                int[] curr = new int[currentList.Count()];
                currentList.CopyTo(curr, 0);
                uniCombinationSum3.Add(curr);
                return;
            }
            if(k == 0)
            {
                return;
            }

            for(int i=index; i<= 9; i++)
            {
                currentList.Add(i);
                FindCombinationSum3(k - 1, n - i, currentList, i+1);
                currentList.RemoveAt(currentList.Count()  - 1);
            }
        }
}