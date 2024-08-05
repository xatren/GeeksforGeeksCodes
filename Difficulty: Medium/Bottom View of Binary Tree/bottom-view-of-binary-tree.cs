//{ Driver Code Starts
//Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Node
{
    public int data;
    public Node left;
    public Node right;

    public Node(int key)
    {
        this.data = key;
        this.left = null;
        this.right = null;
    }
}

namespace DriverCode
{
    class GFG
    {
        // Function to Build Tree
        public Node buildTree(string str)
        {
            // Corner Case
            if (str.Length == 0 || str[0] == 'N')
                return null;

            // Creating vector of strings from input
            // string after spliting by space
            var ip = str.Split(' ');



            Node root = new Node(int.Parse(ip[0]));


            // Push the root to the queue
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            // Starting from the second element
            int i = 1;
            while (queue.Count != 0 && i < ip.Length)
            {

                // Get and remove the front of the queue
                Node currNode = queue.Peek();
                queue.Dequeue();

                // Get the current node's value from the string
                string currVal = ip[i];

                // If the left child is not null
                if (currVal != "N")
                {

                    // Create the left child for the current node
                    currNode.left = new Node(int.Parse(currVal));

                    // Push it to the queue
                    queue.Enqueue(currNode.left);
                }

                // For the right child
                i++;
                if (i >= ip.Length)
                    break;
                currVal = ip[i];

                // If the right child is not null
                if (currVal != "N")
                {

                    // Create the right child for the current node
                    currNode.right = new Node(int.Parse(currVal));

                    // Push it to the queue
                    queue.Enqueue(currNode.right);
                }
                i++;
            }

            return root;
        }
        
        void inorder(Node root){
            if(root==null) return;
            inorder(root.left);
            Console.Write(root.data + " ");
            inorder(root.right);
        }
        
        
        

        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                var gfg = new GFG();
                var str = Console.ReadLine().Trim();
                var root = gfg.buildTree(str);
                Solution obj = new Solution();
                var res = obj.bottomView(root);
                foreach(int i in res){
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

/*  A binary tree Node
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int key)
        {
            this.data = key;
            this.left = null;
            this.right = null;
        }
    }
*/
class Solution
{
    
    //Function to return a list containing the bottom view of the given tree.
    public List<int> bottomView(Node root)
    {
       // Your Code Here
       if (root == null)
                return new List<int>();

            Dictionary<int, int> bottomViewMap = new Dictionary<int, int>();
            
            Queue<Tuple<Node, int>> queue = new Queue<Tuple<Node, int>>();

            queue.Enqueue(new Tuple<Node, int>(root, 0));

            while (queue.Count > 0)
            {
                Tuple<Node, int> current = queue.Dequeue();
                Node node = current.Item1;
                int hd = current.Item2;

                bottomViewMap[hd] = node.data;

                if (node.left != null)
                    queue.Enqueue(new Tuple<Node, int>(node.left, hd - 1));
                if (node.right != null)
                    queue.Enqueue(new Tuple<Node, int>(node.right, hd + 1));
            }

            List<int> bottomViewResult = new List<int>();
            foreach (var key in bottomViewMap.Keys.OrderBy(key => key))
            {
                bottomViewResult.Add(bottomViewMap[key]);
            }

            return bottomViewResult;

    }
}