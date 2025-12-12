// Last updated: 12/11/2025, 8:02:25 PM
public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new();
        while(!set.Contains(n))
        {
            set.Add(n);
            n = CalculateSum(n);
            if(n == 1)
            {
                return true;
            }
        }
        return false;
    }
    private int CalculateSum(int n)
    {
        int newNum=0, lastDigit=0;
        while(n != 0)
        {
            lastDigit = n % 10;
            n = n /10;
            newNum += lastDigit * lastDigit;
        }
        return newNum;
    }

}