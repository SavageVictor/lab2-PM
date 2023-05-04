using System;

public class Node
{
    public char Data;
    public Node Next;

    public Node(char data)
    {
        Data = data;
        Next = null;
    }
}

public class CircularLinkedList
{
    private Node head;

    public CircularLinkedList()
    {
        head = null;
    }

    public int Length()
    {
        if (head == null)
        {
            return 0;
        }

        int count = 1;
        Node current = head;

        while (current.Next != head)
        {
            count++;
            current = current.Next;
        }

        return count;
    }

    public void Append(char element)
    {
        Node newNode = new Node(element);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
        }
        else
        {
            Node current = head;

            while (current.Next != head)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Next = head;
        }
    }

    public void Insert(char element, int index)
    {
        if (index < 0 || index > Length())
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        Node newNode = new Node(element);

        if (index == 0)
        {
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                Node current = head;

                while (current.Next != head)
                {
                    current = current.Next;
                }

                newNode.Next = head;
                head = newNode;
                current.Next = head;
            }
        }
        else
        {
            int currentIndex = 0;
            Node current = head;

            while (currentIndex < index - 1)
            {
                currentIndex++;
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public char Delete(int index)
    {
        if (index < 0 || index >= Length())
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        Node current = head;
        char removedData;

        if (index == 0)
        {
            removedData = head.Data;

            if (Length() == 1)
            {
                head = null;
            }
            else
            {
                Node lastNode = head;

                while (lastNode.Next != head)
                {
                    lastNode = lastNode.Next;
                }

                head = head.Next;
                lastNode.Next = head;
            }
        }
        else
        {
            int currentIndex = 0;

            while (currentIndex < index - 1)
            {
                currentIndex++;
                current = current.Next;
            }

            removedData = current.Next.Data;
            current.Next = current.Next.Next;
        }

        return removedData;
    }

    public void DeleteAll(char element)
    {
        int length = Length();

        for (int i = 0; i < length; i++)
        {
            if (head.Data == element)
            {
                Delete(0);
            }
            else
            {
                break;
            }
        }

        if (head != null)
        {
            Node current = head;

            while (current.Next != head)
            {
                if (current.Next.Data == element)

                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
    }

    public char Get(int index)
    {
        if (index < 0 || index >= Length())
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        int currentIndex = 0;
        Node current = head;

        while (currentIndex < index)
        {
            currentIndex++;
            current = current.Next;
        }

        return current.Data;
    }

    public CircularLinkedList Clone()
    {
        CircularLinkedList clonedList = new CircularLinkedList();
        Node current = head;

        if (head != null)
        {
            do
            {
                clonedList.Append(current.Data);
                current = current.Next;
            } while (current != head);
        }

        return clonedList;
    }

    public void Reverse()
    {
        if (Length() <= 1)
        {
            return;
        }

        Node prev = null;
        Node current = head;
        Node next = null;
        Node lastNode = head;

        do
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        } while (current != head);

        head = prev;
        lastNode.Next = head;
    }

    public int FindFirst(char element)
    {
        int index = 0;
        Node current = head;

        if (head != null)
        {
            do
            {
                if (current.Data == element)
                {
                    return index;
                }

                index++;
                current = current.Next;
            } while (current != head);
        }

        return -1;
    }

    public int FindLast(char element)
    {
        int index = -1;
        int currentIndex = 0;
        Node current = head;

        if (head != null)
        {
            do
            {
                if (current.Data == element)
                {
                    index = currentIndex;
                }

                currentIndex++;
                current = current.Next;
            } while (current != head);
        }

        return index;
    }

    public void Clear()
    {
        head = null;
    }

    public void Extend(CircularLinkedList elements)
    {
        Node current = elements.head;

        if (elements.head != null)
        {
            do
            {
                Append(current.Data);
                current = current.Next;
            } while (current != elements.head);
        }
    }
}