// Last updated: 12/11/2025, 8:02:11 PM
public class Solution {
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        IList<IList<int>> result = new List<IList<int>>();
        IList<Tuple<int, int, bool>> points = GetSortedBuildingPoints(buildings);

        int currentMaxHeight = 0, previousMaxHeight = 0;
        IDictionary<int, int> map = new Dictionary<int, int>();
        map.Add(0, 1);

        for (int i = 0; i < points.Count; i++)
        {
            if (points[i].Item3)
            {
                if (map.ContainsKey(points[i].Item2))
                {
                    map[points[i].Item2] += 1;
                }
                else
                {
                    map.Add(points[i].Item2, 1);
                }
            }
            else
            {
                if (map.ContainsKey(points[i].Item2))
                {
                    if(map[points[i].Item2] > 1)
                    {
                        map[points[i].Item2] -= 1;
                    }
                    else
                    {
                        map.Remove(points[i].Item2);
                    }
                }
            }
            currentMaxHeight = map.Aggregate((x, y) => x.Key > y.Key ? x : y).Key;

            if (currentMaxHeight != previousMaxHeight)
            {
                previousMaxHeight = currentMaxHeight;

                result.Add(new List<int> { points[i].Item1, currentMaxHeight });
            }
        }

        return result;
    }

    IList<Tuple<int, int, bool>> GetSortedBuildingPoints(int[][] buildings)
    {
        IList<Tuple<int, int, bool>> points = new List<Tuple<int, int, bool>>();
        for (int i = 0; i < buildings.Length; i++)
        {
            points.Add(new Tuple<int, int, bool>(buildings[i][0], buildings[i][2], true));
            points.Add(new Tuple<int, int, bool>(buildings[i][1], buildings[i][2], false));
        }

        List<Tuple<int, int, bool>> result = points.Where(item => item.Item3).OrderBy(item => item.Item1).ThenByDescending(item => item.Item2).ToList();

        result.AddRange(points.Where(item => !item.Item3).OrderBy(item => item.Item1).ThenBy(item => item.Item2).ToList());

        result = result.OrderBy(item => item.Item1).ToList();
        return result;
    }
    
}