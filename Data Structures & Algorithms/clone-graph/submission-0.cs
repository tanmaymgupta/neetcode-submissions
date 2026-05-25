/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return null;
        Dictionary<Node, Node> clone_map = new Dictionary<Node, Node>();
        DFSCloneNodes(node, clone_map);

        foreach(var kvp in clone_map)
        {
            LinkNodes(kvp.Key, clone_map);
        }
        return clone_map[node];
    }

    public void DFSCloneNodes(Node curr, Dictionary<Node, Node> clone_map)
    {
        if(clone_map.ContainsKey(curr))
        {
            return;
        }
        
        clone_map[curr] = new Node(curr.val);
        foreach(var neighbor in curr.neighbors)
        {
            DFSCloneNodes(neighbor, clone_map);
        }
    }

    public void LinkNodes(Node curr, Dictionary<Node, Node> clone_map)
    {
        var cloneNode = clone_map[curr];
        foreach(var neighbor in curr.neighbors)
        {
            cloneNode.neighbors.Add(clone_map[neighbor]);
        }
    }
}
