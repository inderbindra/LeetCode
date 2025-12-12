// Last updated: 12/11/2025, 8:00:10 PM
public class Solution {
    bool[] visited;
    public bool CanReach(int[] arr, int start) {
        visited = new bool[arr.Length];
        return Jump(arr, start);
    }
    private bool Jump(int[] arr, int start)
    {
        if(start < 0 || start >= arr.Length)
        {
            return false;
        }
        if(arr[start] == 0)
        {
            return true;
        }
        if(visited[start])
        {
            return false;
        }
        visited[start] = true;
        bool status = Jump(arr, start + arr[start]) || Jump(arr, start - arr[start]);
        return status;
    }
}