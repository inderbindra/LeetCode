// Last updated: 12/11/2025, 8:02:19 PM
public class TrieNode
{
    public Dictionary<char, TrieNode> Children;
    public bool IsEndOfWord;
    public TrieNode()
    {
        this.Children = new();
        this.IsEndOfWord = false;
    }
}

public class WordDictionary {
    TrieNode Root;
    public WordDictionary() {
        this.Root = new TrieNode();
    }
    
    public void AddWord(string word) {
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
        return Search(word, node, 0);
    }
    private bool Search(string word, TrieNode node, int index)
    {
        if(index >= word.Length)
        {
            return node.IsEndOfWord ? true : false;
        }
        if(word[index] == '.')
        {
            foreach(var child in node.Children.Values)
            {
                if(Search(word, child, index+1))
                {
                    return true;
                }
            }
        }
        else if(node.Children.ContainsKey(word[index]))
        {   
            node = node.Children[word[index]];
            return Search(word, node, index+1);
        }
        return false;
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */