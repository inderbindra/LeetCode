// Last updated: 12/11/2025, 8:00:06 PM
public class Solution {
    public int MaxNumberOfFamilies(int n, int[][] reservedSeats) {
        Dictionary<int, bool[]> seatReservedMap = new();
        int familyCount=0;
        int row=0, col=0;
        bool[] allocationGroup;

        for(int i=0; i<reservedSeats.Length; i++)    
        {
            row = reservedSeats[i][0];
            col = reservedSeats[i][1];

            if(col ==1 || col == 10)
            {
                continue;
            }

            allocationGroup = new bool[3]{true, true, true};
            seatReservedMap.TryAdd(row, allocationGroup);

            if(col >=2 && col <=5)
            {
                seatReservedMap[row][0] = false;
            }
            if(col >=4 && col <=7)
            {
                seatReservedMap[row][1] = false;
            }
            if(col >=6 && col <=9)
            {
                seatReservedMap[row][2] = false;
            }
        }
        foreach(var groups in seatReservedMap.Values)
        {
            if(groups[0] || groups[1] || groups[2])
            {
                familyCount++;
            }
        }
        familyCount += (n - seatReservedMap.Count) * 2;
        return familyCount;
    }
}