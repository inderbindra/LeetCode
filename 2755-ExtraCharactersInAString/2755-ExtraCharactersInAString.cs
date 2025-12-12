// Last updated: 12/11/2025, 7:59:48 PM
public class TrieNode
{
    public Dictionary<char, TrieNode> Children {get; set;}
    public bool IsEndOfWord {get; set;}
    public TrieNode()
    {
        this.Children = new();
        this.IsEndOfWord = false;
    }
}

public class Solution {
    TrieNode Root;
    public int MinExtraChar(string s, string[] dictionary) {
        //this.Root = new();
        // AddWords(dictionary);
        // return Search(s);
        int length = 0, i=0;
        int[] dp = new int[s.Length];
        HashSet<string> hashSet = new HashSet<string>(dictionary);
        // for(i=0; i<dictionary.Length; i++)
        // {

        // }
        for(i=0; i<s.Length; i++)
        {
            if(i==0)
            {
                dp[i] = 1;
            }
            else
            {
                dp[i] = dp[i-1] + 1;
            }
            for(int j=i; j>=0; j--)
            {
                length = i-j + 1;
                if(hashSet.Contains(s.Substring(j, length)))
                {
                    dp[i] = Math.Min(dp[i], (j > 0 ? dp[j-1]: 0));
                }
            }
        }
        return dp[s.Length-1];
    }

    // This method add all the words in the dictionary in the Trie Data Structure
    private void AddWords(string[] dictionary)
    {
        TrieNode node = null;
        foreach(var word in dictionary)
        {
            node = this.Root;
            for(int i=0; i<word.Length; i++)
            {
                if(!node.Children.ContainsKey(word[i]))
                {
                    TrieNode newNode = new();
                    node.Children[word[i]] = newNode;
                }
                node = node.Children[word[i]];
            }
            node.IsEndOfWord = true;
        }
    }
    
    
    private int Search(string s)
    {
        int extraLetters = 0;
        TrieNode node = this.Root;

        for(int i=0; i<s.Length; i++)
        {
            if(!node.Children.ContainsKey(s[i]))
            {
                extraLetters++;
                continue;
            }
            node = node.Children[s[i]];
            if(node.IsEndOfWord)
            {
                if(i+1 < s.Length)
                {
                    extraLetters = Math.Min(extraLetters, Search(s.Substring(i+1)));
                }
                else
                {
                    break;
                }
            }
        }
        return extraLetters;
    }
}