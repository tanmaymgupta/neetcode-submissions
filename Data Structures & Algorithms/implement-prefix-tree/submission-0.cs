public class Node {
    public Dictionary<char, Node> dict;
    public string word;
    public Node ()
    {
        dict = new Dictionary<char, Node>();
        word = null;
    }
}

public class PrefixTree {
    Node head;
    public PrefixTree() {
        head = new Node();
    }
    
    public void Insert(string word) {
        Node curr = head;
        foreach(char ch in word)
        {
            char lower_ch = char.ToLower(ch);
            if(!curr.dict.ContainsKey(lower_ch))
            {
                curr.dict[lower_ch] = new Node();
            }
            curr = curr.dict[lower_ch];
        }
        curr.word = word;
    }
    
    public bool Search(string word) {
        Node curr = head;
        foreach(char ch in word)
        {
            char lower_ch = char.ToLower(ch);
            if(curr.dict.ContainsKey(lower_ch))
            {
                curr=curr.dict[lower_ch];
            }
            else
            {
                return false;
            }
        }
        return curr.word != null;
    }
    
    public bool StartsWith(string prefix) {
        Node curr = head;
        foreach(char ch in prefix)
        {
            char lower_ch = char.ToLower(ch);
            if(curr.dict.ContainsKey(lower_ch))
            {
                curr=curr.dict[lower_ch];
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}



