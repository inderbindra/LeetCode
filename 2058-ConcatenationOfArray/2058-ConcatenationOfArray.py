# Last updated: 12/11/2025, 7:59:53 PM
class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:

        numLen = len(nums)
        ans = [None] * (2 * numLen)
        i=0
        for i, num in enumerate(nums):
            ans[i] = num
            ans[i + numLen] = num
            i += 1
        return ans