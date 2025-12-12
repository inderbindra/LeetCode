// Last updated: 12/11/2025, 8:02:29 PM
public class Solution {
    public uint reverseBits(uint n) {
        uint result =0;
        uint bit =0;
        for(int i=0; i<32; i++)
        {
            bit = (n >> i) & 1;
            result = result | (bit << (31 - i));
        }
        return result;
    }
}