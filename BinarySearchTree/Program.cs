namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //constructor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinaryTree
    {
        public node ROOT;
        public BinaryTree()
        {
            ROOT = null; //initializing root to null
        }
        public void insert(string element)// insert a node in the binary
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)//
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else//if the specified node is not present
            {
                tmp = new node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if(string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
    }


}