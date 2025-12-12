// Last updated: 12/11/2025, 8:02:49 PM
public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new(wordList);
        if(!wordSet.Contains(endWord))
        {
            return 0;
        }
        Dictionary<string, IList<string>> adjList = new();
        StringBuilder pattern = new();
        string word, patternStr;

        for(int i=0; i<wordList.Count; i++)
        {
            word = wordList[i];
            pattern.Append(word);
            for(int k=0; k<word.Length; k++)
            {
                pattern[k] = '*';
                patternStr = pattern.ToString();
                adjList.TryAdd(patternStr, new List<string>());
                adjList[patternStr].Add(word);
                pattern[k] = word[k];
            }
            pattern.Clear();
        }

        Queue<string> queue = new();
        queue.Enqueue(beginWord);

        HashSet<string> visitedSet = new();
        visitedSet.Add(beginWord);
        string node;
        int queueLength = 0, ladderLen=0;
        while(queue.Count > 0)
        {
            queueLength = queue.Count;
            ladderLen++;
            for(int i=0; i<queueLength; i++)
            {
                node = queue.Dequeue();
                if(node == endWord)
                {
                    return ladderLen;
                }
                pattern.Append(node);
                for(int k=0; k<node.Length; k++)
                {
                    pattern[k] = '*';
                    patternStr = pattern.ToString();
                    if(adjList.ContainsKey(patternStr))
                    {
                        for(int j=0; j<adjList[patternStr].Count; j++)
                        {
                            if(!visitedSet.Contains(adjList[patternStr][j]))
                            {
                                queue.Enqueue(adjList[patternStr][j]);
                                visitedSet.Add(adjList[patternStr][j]);
                            }
                        }
                    }
                    pattern[k] = node[k];
                }
                pattern.Clear();
            }
        }
        return 0;
    }
}