// Last updated: 12/11/2025, 8:00:35 PM
public class Solution {
    public int PrimePalindrome(int n) {
        int num = n;

        if(n <= 2)
        {
            return 2;
        }
        string s;
        while(true)
        {
            if(num % 2 == 0)
            {
                num++;
                continue;
            }
            // Important is to check IsPalindrome first & then IsPrime.
            if(IsPalindrome(num) && IsPrime(num))
            {
                return num;
            }
            num++;
        }
        return num;
    }
    private bool IsPrime(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        for(int i=2; i<=sqrt; i++)
        {
            if(n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    private bool IsPalindrome(int n)
    {
        string s = n.ToString();
        int left=0, right = s.Length-1;
        while(left < right)
        {
            if(s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}