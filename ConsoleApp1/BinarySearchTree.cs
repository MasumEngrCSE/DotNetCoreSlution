class BinarySearchTree
{
    internal void initialCall()
    {
        BNode root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        // levelOrder(root);


        //BNode root = new BNode(30);
        //var n1 = new BNode(15);
        //var n2 = new BNode(45);
        //var n3 = new BNode(6);
        //var n4 = new BNode(41);
        //var n5 = new BNode(54);


        //root.left = n1;
        //root.right = n2;
        //n1.left = n3;
        //n2.left = n4;
        //n2.right = n5;

        var snode = bsearch(root, 41);
        
        Console.WriteLine(snode==null?"Not Found":snode.value);


    }




    internal BNode bsearch(BNode root,int value)
    {
        if (root == null) return null;

        if(root.value==value) return root;
        else if(root.value>value) root=bsearch(root.left,value);
        else if(root.value<value) root=bsearch(root.right,value);


        return root;
    }





    internal void insertBT()
    {
        BNode root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
       // levelOrder(root);

    }


    internal BNode insert(BNode root, int value)
    {
        if (root == null)
        {
            return new BNode(value);
        }
        else
        {
            BNode cur;
            if (value <= root.value)
            {
                cur = insert(root.left, value);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, value);
                root.right = cur;
            }
            return root;
        }
    }


    internal void levelOrder(BNode root)
    {
        //Write your code here
    }
}



class BNode
{
    public int value;
    public BNode left;
    public BNode right;

    public BNode(int value)
    {
        this.value = value;
    }
}