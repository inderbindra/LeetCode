// Last updated: 12/11/2025, 8:00:37 PM
public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        IList<(int position, int speed)> posSpeed = new List<(int position, int speed)>();
        for(int i=0; i<position.Length; i++)
        {
            posSpeed.Add((position[i], speed[i]));
        }
        posSpeed = posSpeed.OrderByDescending(i=> i.position).ToList();
        Stack<double> stack = new();
        double distance = 0.0;
        for(int i=0; i<posSpeed.Count; i++)
        {
            distance = (target - posSpeed[i].position) / (posSpeed[i].speed * 1.0);
            
            if(stack.Count == 0 || stack.Peek() < distance)
            {
                stack.Push(distance);
            }
        }
        return stack.Count;
    }
}