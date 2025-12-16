// Last updated: 12/15/2025, 8:33:19 PM
1public class Solution {
2    public IList<IList<int>> ThreeSum(int[] nums) {
3        IList<IList<int>> result = new List<IList<int>>();
4        Array.Sort(nums);
5        int left, right, sum=0;
6        for(int i=0; i<nums.Length; i++)
7        {
8            if(i>0 && nums[i] == nums[i-1])
9            {
10                continue;
11            }
12            left = i+1;
13            right = nums.Length-1;
14            while(left < right)
15            {
16                sum = nums[i] + nums[left] + nums[right];
17                if(sum == 0)
18                {
19                    result.Add(new List<int>{nums[i], nums[left], nums[right]});
20                    left++;
21                    while(left < right && nums[left] == nums[left-1])
22                    {
23                        left++;
24                    }
25                }
26                else if(sum < 0)
27                {
28                    left++;
29                }
30                else
31                {
32                    right--;
33                }
34            }
35        }
36        return result;
37    }
38}