/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
    {
        private void Helper(Node node, IList<int> res)
        {
            if (node == null)
            {
                return;
            }

            res.Add(node.val);
            
            foreach (var child in node.children)
            {
                Helper(child, res);
            }

        }

        public IList<int> Preorder(Node root)
        {
            IList<int> res = new List<int>();
            Helper(root, res);
            return res;
        }
    }


// public class Solution {
//     public IList<int> Preorder(Node root) {
//         static IList<int> a = new List<int>();
//         if(root.val == null)  return;
//         // a.Add(root.val);
//         // a = a.children;
//         Queue q = new Queue();
//         while(root.val != null){
//             q.Enqueue(a.val);
//             root = root.children;
//         }
//         while(q.Count > 0){
//             a.Add(q.Peek);
//             q.Dequeue;
//             Preorder
//         }
//         return a;
//     }
// }