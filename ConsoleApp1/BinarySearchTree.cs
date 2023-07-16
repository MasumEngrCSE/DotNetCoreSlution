class BinarySearchTree
{
    internal void initialCall()
    {
        BNode root = new BNode(30);
        var n1 = new BNode(15);
        var n2 = new BNode(45);
        var n3 = new BNode(6);
        var n4 = new BNode(41);
        var n5 = new BNode(54);


        root.left = n1;
        root.right = n2;
        n1.left = n3;
        n2.left = n4;
        n2.right = n5;

        var snode = bsearch(root, 41);
        Console.WriteLine(snode.value);

    }


    internal BNode bsearch(BNode root,int value)
    {

        if(root.value==value) return root;
        else if(root.value>value) root=bsearch(root.left,value);
        else if(root.value<value) root=bsearch(root.right,value);


        return root;
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