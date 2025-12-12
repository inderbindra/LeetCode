// Last updated: 12/11/2025, 7:59:55 PM
public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        
        //return Jump4(s, 0, minJump, maxJump);
        return Jump4_V2(s, minJump, maxJump);
    }
    
    
   /* public bool CanReach(string s, int minJump, int maxJump) {
        if (s[^1] != '0') return false; // can't reach destination
            
        int n = s.Length;
        Queue<int> q = new();
        q.Enqueue(0);
        int farthest = 0;

        while (q.Count > 0) {
            int i = q.Dequeue();
            if (i == n-1) return true;

            int min = Math.Max(i + minJump, farthest); // if farther was already visited, get it, instead of min
            int max = Math.Min(i + maxJump, n-1);// if out of bounds, take the last index (n-1)

            for (int j = min; j <= max; j++) {
                if (s[j] == '0') {
                    q.Enqueue(j);
                }
            }

            farthest = Math.Min(max + 1, n); // without this Math.Min, you will get Time Limit Exceeded
        }
        return false;
    }*/
    
    bool Jump4_V2(string s, int minJump, int maxJump)
    {
        
        if(s[s.Length-1] != '0')
        {
            return false;
        }
        
        Queue<int> q1 = new Queue<int>();
        q1.Enqueue(0);
        
        int index = 0;
        int farthest = 0;
        
        while(q1.Count() > 0)
        {
            index = q1.Dequeue();
            
             if(index == s.Length-1)
             {
                return true;
            }
            
            int min = Math.Max(index + minJump, farthest);
            int max = Math.Min(index + maxJump, s.Length-1);
            
            for(int i=min; i<= max; i++)
            {
                if(s[i] == '0')
                {
                    q1.Enqueue(i);
                   
                }
            }
            farthest = Math.Min(max + 1, s.Length);
        }
        
        return false;
    }
    
    
    
    bool Jump4(string s, int index, int minJump, int maxJump)
    {
        
        if(s[s.Length-1] != '0')
        {
            return false;
        }
        
        int min = index + minJump;
        int max = Math.Min(index + maxJump, s.Length-1);
        bool res = false;
        //Find s[j] == '0'
        
        for(int j = max; j>= min; j--)
        {
            if(s[j] == '0')
            {
                if(j == s.Length -1)
                {
                    return true;
                }
                else if(j != s.Length -1)
                {
                    res = Jump4(s, j, minJump, maxJump);
                } 
            }
        }
        
        return res;
       
    }
}