// Last updated: 12/11/2025, 8:00:55 PM
public class Solution {
    public int[] SmallestRange(IList<IList<int>> nums) {
        PriorityQueue<(int num, int numList, int numIndex), int> pq = new();
        int maxNum = int.MinValue, nextNum = 0, numList=0, nextNumIndex=0;
        int[] result = new int[]{ -100000, 100000};

        //Enqueue first element, list index and element index in the Priority Queue
        // Also calculate the max num from the first elements of all the lists.
        for(int i=0; i<nums.Count; i++)
        {
            pq.Enqueue((nums[i][0], i, 0), nums[i][0]);
            maxNum = Math.Max(maxNum, nums[i][0]);
        }

        (int num, int numList, int numIndex) minNum = (0, 0, 0);
        while(pq.Count > 0)
        {
            minNum = pq.Dequeue();
            //Update the result if the new range is less than the current range.
            if(result[1] - result[0] > maxNum - minNum.num)
            {
                result[0] = minNum.num;
                result[1] = maxNum;
            }

            // Get the num List and calculate the nextNum index
            numList = minNum.numList;
            nextNumIndex = minNum.numIndex + 1;

            // If the nextNumIndex >= then the numList count, then break.
            if(nextNumIndex >= nums[numList].Count)
            {
                break;
            }

            //Else assign the nextNum from the list and calculate the maxNum and queue the the nextNum.
            nextNum = nums[numList][nextNumIndex];
            maxNum = Math.Max(maxNum, nextNum);
            pq.Enqueue((nextNum, numList, nextNumIndex), nextNum);
        }
        return result;
    }
}