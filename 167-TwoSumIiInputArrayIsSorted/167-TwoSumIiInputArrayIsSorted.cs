// Last updated: 12/11/2025, 8:02:33 PM
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left=0, right=numbers.Length-1, sum=0;
        int[] result = null;
        while(left<=right)
        {
            sum = numbers[left] + numbers[right];
            if(sum == target)
            {
                result = new int[]{left+1, right+1};
                break;
            }
            else if(sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return result;
    }
}