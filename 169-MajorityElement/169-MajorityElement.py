# Last updated: 12/11/2025, 8:02:30 PM
class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        count=0
        res=0

        for i in range(len(nums)):
            if count == 0:
                res = nums[i]
                count += 1
            elif res == nums[i]:
                count += 1
            else:
                count -= 1
        return res
                
            