// Last updated: 12/11/2025, 8:00:58 PM
public class Solution {
    public string NearestPalindromic(string n) {
        int mid = n.Length / 2;
        bool isEven = (n.Length % 2 == 0);
        int firstHalfLength = isEven ? mid : mid+1;
        long firstHalfNum = Convert.ToInt64(n.Substring(0, firstHalfLength));
        List<long> possibleNums = new();
        
        possibleNums.Add(GeneratePalindromeNums(firstHalfNum, isEven));
        possibleNums.Add(GeneratePalindromeNums(firstHalfNum + 1, isEven)); // For case like 129 in that case close Palindrome will be 131
        possibleNums.Add(GeneratePalindromeNums(firstHalfNum - 1, isEven)); 

        // For cases like 101, 1001, 10001 in that case the closest Palindrome will be 99, 999, 9999 & so on.
        // For case like 11 in that case close Palindrome will be 9.
        possibleNums.Add((long)Math.Pow(10, n.Length-1) - 1);   

        // For cases like 99, 999, 9999 in that case the closest Palindrome will be 101, 1001, 10001 & so on.
        possibleNums.Add((long)Math.Pow(10, n.Length) + 1);     

        long minDiff = long.MaxValue, diff=0;
        long num = Convert.ToInt64(n);
        long result = 0;
        for(int i=0; i<possibleNums.Count; i++)
        {
            if(num == possibleNums[i])
            {
                continue;
            }
            diff = Math.Abs(num - possibleNums[i]);
            if(minDiff > diff)
            {
                minDiff = diff;
                result = possibleNums[i];
            }
            else if(minDiff == diff)
            {
                result = Math.Min(result, possibleNums[i]);
            }
        }
        
        return result.ToString();
    }
    private long GeneratePalindromeNums(long firstHalfNum, bool isEven)
    {
        long resultNum = firstHalfNum;
        if(!isEven) // That means original string n length was odd
        {
            // Removing the last digit as for odd string we need start to duplicating the number from last index - 1 digit.
            firstHalfNum = firstHalfNum / 10;
        }
        int digit = 0;
        while(firstHalfNum > 0)
        {
            digit = (int)firstHalfNum % 10;
            resultNum = (resultNum * 10) + digit;
            firstHalfNum /= 10;
        }
        return resultNum;
    }
}