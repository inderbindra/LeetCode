// Last updated: 1/5/2026, 4:28:24 PM
1public class TrieNode
2{
3    public IDictionary<char, TrieNode> Children;
4    public bool IsEndOfWord;
5
6    public TrieNode()
7    {
8        this.Children = new Dictionary<char, TrieNode>();
9        this.IsEndOfWord = false;
10    }
11}
12
13public class Trie {
14    public TrieNode Root;
15    public Trie() {
16        this.Root = new TrieNode();
17    }
18    
19    public void Insert(string word) {
20        TrieNode node = this.Root;
21        for(int i=0; i<word.Length; i++)        
22        {
23            if(!node.Children.ContainsKey(word[i]))
24            {
25                node.Children.TryAdd(word[i], new TrieNode());
26            }
27            node = node.Children[word[i]];
28        }
29        node.IsEndOfWord = true;
30    }
31    
32    public bool Search(string word) {
33        TrieNode node = this.Root;
34        for(int i=0; i<word.Length; i++)        
35        {
36            if(!node.Children.ContainsKey(word[i]))
37            {
38                return false;
39            }
40            node = node.Children[word[i]];
41        }
42        return node.IsEndOfWord;
43    }
44    
45    public bool StartsWith(string prefix) {
46        TrieNode node = this.Root;
47        for(int i=0; i<prefix.Length; i++)        
48        {
49            if(!node.Children.ContainsKey(prefix[i]))
50            {
51                return false;
52            }
53            node = node.Children[prefix[i]];
54        }
55        return true;
56    }
57}
58
59/**
60 * Your Trie object will be instantiated and called as such:
61 * Trie obj = new Trie();
62 * obj.Insert(word);
63 * bool param_2 = obj.Search(word);
64 * bool param_3 = obj.StartsWith(prefix);
65 */