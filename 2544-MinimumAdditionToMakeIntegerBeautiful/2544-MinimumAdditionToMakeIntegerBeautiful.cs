// Last updated: 12/11/2025, 7:59:50 PM
public class Solution {
    public long MakeIntegerBeautiful(long n, int target) {
    
        long result = 0, actualNum = n, lastDigit = 0, noToAdd = 0;
        int tensPower = 0;

        long sum = CalculateSumOfDigits(n);
        
        while(sum > target)
        {
            if(n % 10 == 0)
            {
                tensPower++;
                n = n / 10;
            }
            else
            {
                lastDigit = n % 10;
                
                noToAdd = 10 - lastDigit;
                n += noToAdd;
                
                sum = CalculateSumOfDigits(n);
                             
                //Adding this condition as 10 pow 0 is equal to 1, so to avoid adding extra 1.
                if(tensPower > 0)
                {
                    result += ((long)Math.Pow(10, tensPower) * noToAdd);
                }
                else
                {
                    result += noToAdd;
                }
            }
        }
        
        return result;

    }
    
    long CalculateSumOfDigits(long n)
    {
        long sum=0;
        long lastDigit = 0;
        
        //Calculate sum of digits of n
        while(n > 0)
        {
            lastDigit = n % 10;
            n = n / 10;
            sum += lastDigit;
            
        }
        
        return sum;
    }
}