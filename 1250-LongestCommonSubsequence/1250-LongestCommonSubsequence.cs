// Last updated: 12/11/2025, 8:00:18 PM
public class Solution {
    Dictionary<(int t1index, int t2index), int> dp;
    public int LongestCommonSubsequence(string text1, string text2) {
        dp = new();
        return FindLCS(text1, text2, 0, 0);
    }
    private int FindLCS(string text1, string text2, int t1index, int t2index)
    {
        if(t1index == text1.Length || t2index == text2.Length)
        {
            return 0;
        }

        if(dp.ContainsKey((t1index, t2index)))
        {
            return dp[(t1index, t2index)];
        }

        int seq = 0;
        if(text1[t1index] == text2[t2index])
        {
            seq = 1 + FindLCS(text1, text2, t1index+1, t2index+1);
        }
        else
        {
            seq = Math.Max(FindLCS(text1, text2, t1index+1, t2index), FindLCS(text1, text2, t1index, t2index+1));
        }
        dp[(t1index, t2index)] = seq;
        return seq;
    }
}