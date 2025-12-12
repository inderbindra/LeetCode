// Last updated: 12/11/2025, 8:00:05 PM
public class UndergroundSystem {
    Dictionary<int, (string checkInStation, int time)> customerCheckIns = null;
    Dictionary<(string checkInStation, string checkOutStation), (int totalTime, int count)> checkInCheckOutTime = null;

    public UndergroundSystem() {
        customerCheckIns = new();
        checkInCheckOutTime = new();
    }
    
    public void CheckIn(int id, string stationName, int t) {
        customerCheckIns.TryAdd(id, (stationName, t));
        customerCheckIns[id] = (stationName, t);
    }
    
    public void CheckOut(int id, string stationName, int t) {
        if(checkInCheckOutTime.ContainsKey((customerCheckIns[id].checkInStation, stationName)))
        {
            (int totalTime, int count) = checkInCheckOutTime[(customerCheckIns[id].checkInStation, stationName)] ;
            checkInCheckOutTime[(customerCheckIns[id].checkInStation, stationName)] = (totalTime + (t - customerCheckIns[id].time), ++count);
        }
        else
        {
            checkInCheckOutTime.Add((customerCheckIns[id].checkInStation, stationName), (t - customerCheckIns[id].time, 1));
        }
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        double avgTime = 0.0;
        (int totalTime, int count) = checkInCheckOutTime[(startStation, endStation)];
        avgTime = totalTime / (count * 1.0);
        return avgTime;
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */