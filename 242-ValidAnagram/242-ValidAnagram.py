# Last updated: 12/11/2025, 8:02:03 PM
class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        anagramDict = {}

        if len(s) != len(t):
            return False
        for char in s:
            if char in anagramDict:
                anagramDict[char] += 1
            else:
                anagramDict[char] = 1
        
        for char in t:
            if anagramDict.get(char) == None:
                return False
            else:
                anagramDict[char] -= 1
                if anagramDict[char] == 0:
                    del anagramDict[char]
        return True if len(anagramDict) == 0 else False
