using System;
//Binary Tree DSA

namespace Tree
{
    internal class Program
    {
        internal class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public static void InOrder(Node root)
        {
            if(root==null) return;
            
            PreOrder(root.left);
            Console.Write(root.data +" ");
            PreOrder(root.right);
        }
        
        public static void PreOrder(Node root)
        {
            if(root==null) return;
            
            Console.Write(root.data +" ");
            InOrder(root.left);
            InOrder(root.right);
        }
        
        public static void PostOrder(Node root)
        {
            if(root==null) return;
            
            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data +" ");
            
        }

        private static int idx = -1;
        
        static Node arrcreatTree(int[] arr)
        {
            if (arr.Length < 1) return null;
            idx++;
            
            Node root = null;
            
            int data = arr[idx];
            if (data == -1)
            {
                return null;
            }
            root = new Node(data);
            root.left = arrcreatTree(arr);
            root.right = arrcreatTree(arr);

            return root;

        }

        static Node creatTree()
        {
            Node root = null;
            Console.WriteLine("Enter the Data");
            int data = Convert.ToInt32(Console.ReadLine());
            if (data == -1)
            {
                return null;
            }
            root = new Node(data);
            Console.WriteLine("Enter the left data "+data);
            root.left = creatTree();
            
            Console.WriteLine("Enter the right data "+data);
            root.right = creatTree();

            return root;

        }

        static int height(Node root)
        {
            if (root == null) return 0;
            return Math.Max(height(root.left), height(root.right))+1;
        }

        static int size(Node root)
        {
            if (root == null) return 0;
            return size(root.left) + size(root.right) + 1;
        }


        static void printviaLevel(Node root, int level)
        {
            if (root==null) return;
            if (level == 1) Console.WriteLine(root.data);
            else if (level > 1)
            {
                printviaLevel(root.left,level-1);
                printviaLevel(root.right,level-1);
            }
        }

        // Left View Code Start
        static int max_level = 0;
        static void leftViewUtil(Node node, int level)
        {
            // Base Case
            if (node == null) {
                return;
            }
            if (max_level < level) {
                Console.Write(node.data + " ");
                max_level = level;
            }
            leftViewUtil(node.left, level + 1);
            leftViewUtil(node.right, level + 1);
        }
        static void leftView(Node root)
        {
            leftViewUtil(root, 1);
        }
        //Left View Code End


        //Diameter of Binary Tree
        static int diaMeter(Node root)
        {
            if (root == null) return 0;
            int dl = diaMeter(root.left);
            int dr = diaMeter(root.right);
            int cur = height(root.left) + height(root.right) + 1;
            return Math.Max(cur, Math.Max(dl, dr));
        }
        
        // Lowest common ancestor
        static Node lca(Node root, int num1, int num2)
        {
            if (root == null) return null;
            if (root.data == num1 || root.data == num2) return root;

            Node left = lca(root.left, num1, num2);
            Node right = lca(root.right, num1, num2);

            if (left == null) return right;
            if (right == null) return left;

            return root;
        }
        //Burn Tree from Leaf
        internal class Depth
        {
            public int d;
            public Depth(int d)
            {
                this.d = d;
            }
        }

        private static int ans = -1;
        public static int minTime(Node root, int target)
        {
            Depth dep = new Depth(-1);
            burn(root, target, dep);
            return ans;
        }

        public static int burn(Node root, int target, Depth depth)
        {
            if (root == null) return 0;
            if (root.data == target)
            {
                depth.d = 0;
                return 1;
            }

            Depth ld = new Depth(-1);
            Depth rd = new Depth(-1);

            int lh = burn(root.left, target, ld);
            int rh = burn(root.right, target, rd);

            if (ld.d != -1)
            {
                ans = Math.Max(ans, ld.d + 1+rh);
                depth.d = ld.d + 1;
            }
            else if (rd.d != -1)
            {
                ans = Math.Max(ans, rd.d + 1+lh);
                depth.d = rd.d + 1;
            }

            return Math.Max(lh, rh) + 1;
        }

        
        public static void Main(string[] args)
        {
           int[] arr = {1,2,3,-1,-1,4,-1,-1,5,-1,7,-1,-1};
           Node root =  arrcreatTree(arr);
           InOrder(root);
           Console.WriteLine();
           PreOrder(root);
           Console.WriteLine();
           PostOrder(root);
           Console.WriteLine();
           Console.WriteLine(height(root));
           Console.WriteLine();
           Console.WriteLine(size(root));
           Console.WriteLine();
           printviaLevel(root,1);
           Console.WriteLine();
           leftView(root);
           Console.WriteLine();
           Console.WriteLine(diaMeter(root));
           Node lcadata = lca(root, 13, 41);
           Console.WriteLine(lcadata.data);
           Console.WriteLine(minTime(root,2));

        }
    }
}
