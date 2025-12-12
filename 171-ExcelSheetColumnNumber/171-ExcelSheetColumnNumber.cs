// Last updated: 12/11/2025, 8:02:29 PM
public class Solution {
    public int TitleToNumber(string columnTitle) {
        int num = 0;
        for(int i=0; i<columnTitle.Length; i++)
        {
            num += (int)Math.Pow(26, columnTitle.Length - i - 1) * (columnTitle[i] - 'A' + 1);
        }
        return num;
    }
}