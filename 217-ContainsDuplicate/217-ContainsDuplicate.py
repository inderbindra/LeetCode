# Last updated: 12/11/2025, 8:02:14 PM
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        numSet = set()
        for num in nums:
            if num in numSet:
                return True
            numSet.add(num)
        return False
