// Last updated: 12/11/2025, 8:02:21 PM
public class TrieNode
{
    public Dictionary<char, TrieNode> Children;
    public bool IsEndOfWord;
    public TrieNode()
    {
        this.Children = new Dictionary<char, TrieNode>();
        this.IsEndOfWord = false;
    }
}

public class Trie {
    TrieNode Root;
    public Trie() {
        this.Root = new();
    }
    
    public void Insert(string word) {
        TrieNode node = this.Root;
        for(int i=0; i<word.Length; i++)
        {
            if(!node.Children.ContainsKey(word[i]))
            {
                node.Children.Add(word[i], new TrieNode());
            }
            node = node.Children[word[i]];
        }
        node.IsEndOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode node = this.Root;
        for(int i=0; i<word.Length; i++)
        {
            if(!node.Children.ContainsKey(word[i]))
            {
                return false;
            }
            node = node.Children[word[i]];
        }
        return node.IsEndOfWord ? true : false;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode node = this.Root;
        for(int i=0; i<prefix.Length; i++)
        {
            if(!node.Children.ContainsKey(prefix[i]))
            {
                return false;
            }
            node = node.Children[prefix[i]];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */