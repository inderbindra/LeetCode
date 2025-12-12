// Last updated: 12/11/2025, 8:01:56 PM
public class Solution {
    public bool IsAdditiveNumber(string num)
    {
        int numLength = num.Length;
        string num1, num2;

        for (int i = 1; i < numLength - 1; i++)
        {
            num1 = num.Substring(0, i);
            if (num1.ToString()[0] == '0' && i > 1)
            {
                break;
            }
            for (int j = i+1; j < numLength; j++)
            {
                num2 = num.Substring(i, j - i);
                if (num2.ToString()[0] == '0' && j - i > 1)
                {
                    break;
                }

                bool result = Calculate(Convert.ToInt64(num1), Convert.ToInt64(num2), num.Substring(j), false);
                if (result) return true;
            }
        }
        return false;
    }

    public bool Calculate(long n1, long n2, string s, bool result)
    {
        if (s.Length == 0 && result)
        {
            return true;
        }

        string num3 = (n1 + n2).ToString();
        int index = Math.Min(s.Length, num3.Length);
        if (s.Substring(0, index) == num3)
        {
            return Calculate(n2, Convert.ToInt64(num3), s.Substring(index), true);
        }
        return false;
    }

}