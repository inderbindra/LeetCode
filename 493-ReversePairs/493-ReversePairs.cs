// Last updated: 12/11/2025, 8:01:35 PM
public class Solution {
    
    int count=0;
    public int ReversePairs(int[] nums) {
        long[] array = nums.Select(item => (long)item).ToArray();
        Divide(array);
        return count;
    }

    private long[] Divide(long[] nums)
    {
        if(nums.Length == 1)
        {
            return nums;
        }
        int mid = nums.Length/2;
        long[] leftArray, rightArray, result;
        leftArray = new long[mid];
        for(int i=0; i<mid; i++)
        {
            leftArray[i] = nums[i];
        }
        rightArray = new long[nums.Length - mid];
        for(int i=0; i< rightArray.Length; i++)
        {
            rightArray[i] = nums[mid + i];
        }
        leftArray = Divide(leftArray);
        rightArray = Divide(rightArray);
        result = Merge(leftArray, rightArray);
        return result;
    }

    private long[] Merge(long[] leftArray, long[] rightArray)
    {
        int i=0, j=0, k=0;
        long[] result = new long[leftArray.Length + rightArray.Length];
        
        for (i = 0; i < leftArray.Length; i++)
        {
            while (j < rightArray.Length && leftArray[i] > (2 * rightArray[j]))
            {
                j++;
            }
            count += j;
        }
        i=0; j=0;
        while(i < leftArray.Length && j < rightArray.Length)
        {
            if(leftArray[i] < rightArray[j])
            {
                result[k] = leftArray[i];
                i++;
            }
            else
            {
                result[k] = rightArray[j];
                j++;
            }
            k++;
        }
        while(i < leftArray.Length)
        {
            result[k] = leftArray[i];
            i++; 
            k++;
        }
        while(j < rightArray.Length)
        {
            result[k] = rightArray[j];
            j++; 
            k++;
        }
        return result;
    }
}