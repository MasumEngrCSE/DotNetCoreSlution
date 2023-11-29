using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}
class linked_listSolution
{

    public  Node insert(Node head, int data)
    {
        //Complete this method

        Node node = new Node(data);

        if (head == null)
            head = node;
        else
        {
            Node tt = head;
            while (tt.next != null)
            {
                tt = tt.next;
            }

            tt.next = node;
        }

        return node;

        ////end


    }

    public void display(Node head)
    {
        Node start = head;
        while (start != null)
        {
            Console.Write(start.data + " ");
            start = start.next;
        }
    }
    internal void initialCall()
    {

        Node head = null;
        Console.Write("Enter Total Node :");
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            Console.Write($"Enter valu for Node {T} :");
            int data = Int32.Parse(Console.ReadLine());
            head = insert(head, data);
        }
        display(head);
    }
}