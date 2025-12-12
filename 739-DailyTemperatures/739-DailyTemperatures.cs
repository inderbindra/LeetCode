// Last updated: 12/11/2025, 8:00:51 PM
public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<(int temp, int index)> stack = new();
        int[] result = new int[temperatures.Length];
        (int temp, int index) item = (0, 0);
        for(int i=0; i<temperatures.Length; i++)
        {
            while(stack.Count > 0 && stack.Peek().temp < temperatures[i])
            {
                item = stack.Pop();
                result[item.index] = i - item.index;
            }
            stack.Push((temperatures[i], i));
        }
        return result;
    }
}