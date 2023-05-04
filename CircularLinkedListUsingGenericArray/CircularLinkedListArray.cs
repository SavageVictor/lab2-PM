using System;

public class CircularLinkedListArray
{
    private char[] elements;
    private int count;

    public CircularLinkedListArray()
    {
        elements = new char[0];
        count = 0;
    }

    public int Length()
    {
        return count;
    }

    public void Append(char value)
    {
        Array.Resize(ref elements, count + 1);
        elements[count] = value;
        count++;
    }

    public void Insert(char value, int index)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException("Некоректне значення позиції");
        }

        Array.Resize(ref elements, count + 1);
        Array.Copy(elements, index, elements, index + 1, count - index);
        elements[index] = value;
        count++;
    }

    public char Delete(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("Некоректне значення позиції");
        }

        char deletedValue = elements[index];
        Array.Copy(elements, index + 1, elements, index, count - index - 1);
        Array.Resize(ref elements, count - 1);
        count--;

        return deletedValue;
    }

    public void DeleteAll(char value)
    {
        int index = 0;
        while (index < count)
        {
            if (elements[index] == value)
            {
                Delete(index);
            }
            else
            {
                index++;
            }
        }
    }

    public char Get(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("Некоректне значення позиції");
        }

        return elements[index];
    }

    public CircularLinkedListArray Clone()
    {
        CircularLinkedListArray newList = new CircularLinkedListArray();
        newList.elements = (char[])elements.Clone();
        newList.count = count;
        return newList;
    }

    public void Reverse()
    {
        Array.Reverse(elements);
    }

    public int FindFirst(char value)
    {
        for (int i = 0; i < count; i++)
        {
            if (elements[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public int FindLast(char value)
    {
        for (int i = count - 1; i >= 0; i--)
        {
            if (elements[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    public void Clear()
    {
        elements = new char[0];
        count = 0;
    }

    public void Extend(CircularLinkedListArray list)
    {
        int newCount = count + list.count;
        Array.Resize(ref elements, newCount);
        Array.Copy(list.elements, 0, elements, count, list.count);
        count = newCount;
    }
}
