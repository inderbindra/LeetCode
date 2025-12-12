// Last updated: 12/11/2025, 8:01:44 PM
public class Solution {
    public int GetSum(int a, int b) {
        // Addition using XOR and Logical And
        // Logical And is used to handle carry
        int temp=0;
        while(b != 0)
        {
            temp = (a & b) <<1;
            a = a ^ b;
            b = temp;
        }
        return a;
    }
}