// Last updated: 12/11/2025, 8:00:44 PM
public class Solution {
    public bool CanTransform(string start, string end) {
        
      
       /* if(start.Length == 1 &&  !start.Equals(end))
        {
            return false;
        }
        else if(start.Equals(end))
        {
            return true;
        }*/
            
        IList<Tuple<char, int>> startMap = new List<Tuple<char, int>>();
        IList<Tuple<char, int>> endMap = new List<Tuple<char, int>>();

        for(int i=0; i< start.Length; i++)
        {
            if(start[i] != 'X')
            {
                startMap.Add(new Tuple<char, int>(start[i], i));
            }
            
            if(end[i] != 'X')
            {
                endMap.Add(new Tuple<char, int>(end[i], i));
            }
        }
        
        // If the startMap.count does not match endMap.Count, that means the strings does not have same number of L & R characters.
        // Or If startMap.Count == start.Length that means if the strings does not contain any X in the string Ex: "LLR" "RRL"
        if(startMap.Count != endMap.Count || startMap.Count == start.Length)
        {
            return false;
        }
        else
        {
            for(int i=0; i< startMap.Count; i++)
            {
                // The index of L in the startMap should always be greater than endMap becoz after conversion the index of 'L' will be reduced. If this condition is not true, then the string cannot be coverted.
                if(startMap[i].Item1 == 'L' && startMap[i].Item2 < endMap[i].Item2)
                {
                    return false;
                }
           
                // The index of R in the startMap should always be less than endMap becoz after conversion the index of 'R' will be increased. If this condition is not true, then the string cannot be coverted.
                if(startMap[i].Item1 == 'R' && startMap[i].Item2 > endMap[i].Item2)
                {
                    return false;
                }
            }
            return true;
        }
       
    }
}
