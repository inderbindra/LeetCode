// Last updated: 1/3/2026, 6:13:35 PM
1public class Solution {
2    
3    IList<IList<int>> result;
4    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
5        result = new List<IList<int>>();
6        BackTrack(candidates, target, new List<int>(), 0);
7        return result;
8    }
9
10    private void BackTrack(int[] candidates, int target, IList<int> currentList, int index)
11    {
12        if(target == 0)
13        {
14            result.Add(new List<int>(currentList));
15            return;
16        }
17        int diff = 0;
18        for(int i=index; i<candidates.Length; i++)
19        {
20            diff = target - candidates[i];
21            if(diff >= 0)
22            {
23                currentList.Add(candidates[i]);
24                BackTrack(candidates, diff, currentList, i);
25                currentList.RemoveAt(currentList.Count - 1);
26            }
27        }
28    }
29}