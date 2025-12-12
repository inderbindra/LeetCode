// Last updated: 12/11/2025, 8:00:20 PM
public class Solution {
    public IList<string> InvalidTransactions(string[] transactions) {
        Dictionary<string, IList<(int index, int time, int amount, string city)>> transactionMap = new();
        IList<string> inValidTrans = new List<string>();
        bool[] inValids = new bool[transactions.Length];
        int i=0;
        bool invalid = false;
        for(i=0; i<transactions.Length; i++)
        {
            var trans = transactions[i].Split(",");
            var item = (index: i, time: int.Parse(trans[1]), amount: int.Parse(trans[2]), city: trans[3]);
            if(item.amount > 1000)
            {
                inValids[i] = true;
            }
            if(transactionMap.ContainsKey(trans[0]))
            {
                var list = transactionMap[trans[0]];
                var invalidIndicies = list.Where(t=> t.city != item.city && Math.Abs(item.time - t.time) <= 60).Select(t=>t.index);

                if(invalidIndicies != null && invalidIndicies.Any())
                {
                    foreach(var pointer in invalidIndicies)
                    {
                        inValids[pointer] = true;
                    }
                    inValids[i] = true;
                }
            }
            transactionMap.TryAdd(trans[0], new List<(int index, int time, int amount, string city)>());
            transactionMap[trans[0]].Add(item);
        }
        for(i=0; i<transactions.Length; i++)
        {
            if(inValids[i])
            {
                inValidTrans.Add(transactions[i]);
            }
        }
        return inValidTrans;
    }
}