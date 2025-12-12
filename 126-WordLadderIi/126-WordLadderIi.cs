// Last updated: 12/11/2025, 8:02:52 PM
public class Solution {
    IList<IList<string>> result;
    Dictionary<string, IList<string>> adjList;
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) {
        HashSet<string> wordSet = new(wordList);
        result = new List<IList<string>>();
        adjList = new();
        if(wordSet.Contains(endWord))
        {
            Queue<string> queue = new();
            queue.Enqueue(beginWord);

            Dictionary<string, int> visitedMap = new();
            visitedMap.Add(beginWord, 0);
            StringBuilder pattern = new();
            string word = string.Empty, patternStr;

            int queueLength =0;
            while(queue.Count > 0)
            {
                queueLength = queue.Count;
                for(int i=0; i<queueLength; i++)
                {
                    word = queue.Dequeue();
                    if(word == endWord)
                    {
                        DFS(word, beginWord, new Stack<string>());
                        break;
                    }
                    pattern.Append(word);
                    for(int j=0; j<word.Length; j++)
                    {
                        for(int k=0; k<26; k++)
                        {
                            pattern[j] = (char)(k + 'a');
                            patternStr = pattern.ToString();
                            if(wordSet.Contains(patternStr))
                            {
                                if(!visitedMap.ContainsKey(patternStr))
                                {
                                    queue.Enqueue(patternStr);
                                    visitedMap.Add(patternStr, 1 + visitedMap[word]);
                                    adjList.TryAdd(patternStr, new List<string>());
                                    adjList[patternStr].Add(word);
                                }
                                // This condition is important to avoid extra cases and avoid TLE.
                                // And also for adding multiple paths like cog -> log & cog -> dog
                                // so this condition will make sure to add cog in adjList key and dog & log in the List.
                                // Suppose word = dog and it will patterStr = cog in visitedMap, then when the loop iterates 
                                // for word = log then it will not add the adjList, that's why this case is added, so it adds it.
                                else if(visitedMap.ContainsKey(patternStr) && visitedMap[patternStr] == 1 + visitedMap[word])
                                {
                                    adjList.TryAdd(patternStr, new List<string>());
                                    adjList[patternStr].Add(word);
                                }
                            }
                        }
                        pattern[j] = word[j];
                    }
                    pattern.Clear();
                }
                if(word == endWord)
                {
                    break;
                }
            }
        }
        return result;
    }
    private void DFS(string word, string beginWord, Stack<string> stack)
    {
        if(word == beginWord)
        {
            stack.Push(word);
            result.Add(new List<string>(stack.ToList()));
            stack.Pop();
            return;
        }
        if(adjList[word].Count > 0)
        {
            stack.Push(word);
            for(int i=0; i<adjList[word].Count; i++)
            {
                DFS(adjList[word][i], beginWord, stack);
            }
            stack.Pop();
        }
    }
}