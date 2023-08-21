using System;

class Node<T>
{
    public Node<T> Next;
    public Node<T> Prev;
    public T Data;
}


class MyLinkedList<T>
{
    Node<T> Head;
    Node<T> Tail;
    public int Count = 0;

    public Node<T> AddLast(T data)
    {
        Node<T> newNode = new Node<T>();
        newNode.Data = data;

        if (Head == null)
            Head = newNode;

        if (Tail != null)
        {
            Tail.Next = newNode;
            newNode.Prev = Tail;
        }

        Tail = newNode;
        Count++;
        return newNode;
    }

    public void Remove(Node<T> node)
    {
        if (Head == node)
            Head = Head.Next;

        if (Tail == node)
            Tail = Tail.Prev;

        if (node.Next != null)
            node.Next.Prev = node.Prev;

        if (node.Prev != null)
            node.Prev.Next = node.Next;

        Count--;

    }


}


class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> linkedlist = new MyLinkedList<int>();

        linkedlist.AddLast(100);
        linkedlist.AddLast(101);
        linkedlist.AddLast(102);
        Node<int> node = linkedlist.AddLast(103);
        linkedlist.AddLast(104);
        linkedlist.Remove(node);
    }
}

