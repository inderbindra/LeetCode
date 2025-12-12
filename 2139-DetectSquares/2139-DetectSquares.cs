// Last updated: 12/11/2025, 7:59:51 PM
public class DetectSquares {
    Dictionary<(int x, int y), int> pointsCount;
    List<(int x, int y)> points;
    public DetectSquares() {
        pointsCount = new();
        points = new();
    }
    
    public void Add(int[] point) {
        pointsCount.TryAdd((point[0], point[1]), 0);
        pointsCount[(point[0], point[1])] += 1;
        points.Add((point[0], point[1]));
    }   
    
    public int Count(int[] point) {
        int res=0;
        for(int i=0; i<points.Count; i++)
        {
            if(Math.Abs(point[0] - points[i].x) != Math.Abs(point[1] - points[i].y) || 
              point[0] == points[i].x || point[1] == points[i].y)
            {
                continue;
            }
            pointsCount.TryGetValue((point[0], points[i].y), out int p1);
            pointsCount.TryGetValue((points[i].x, point[1]), out int p2);
            res += p1 * p2;
        }
        return res;
    }
}

/**
 * Your DetectSquares object will be instantiated and called as such:
 * DetectSquares obj = new DetectSquares();
 * obj.Add(point);
 * int param_2 = obj.Count(point);
 */