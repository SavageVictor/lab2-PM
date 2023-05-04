using NUnit.Framework;
using System;

[TestFixture]
public class CircularLinkedListArrayTests
{
    [Test]
    public void Test_Length()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        Assert.AreEqual(3, list.Length());
    }

    [Test]
    public void Test_Append()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        Assert.AreEqual('a', list.Get(0));
    }

    [Test]
    public void Test_Insert()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        list.Insert('x', 1);
        Assert.AreEqual('x', list.Get(1));
    }

    [Test]
    public void Test_Delete()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        char deleted = list.Delete(1);
        Assert.AreEqual('b', deleted);
    }

    [Test]
    public void Test_DeleteAll()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('a');
        list.DeleteAll('a');
        Assert.AreEqual(1, list.Length());
    }

    [Test]
    public void Test_Get()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        Assert.AreEqual('b', list.Get(1));
    }

    [Test]
    public void Test_Clone()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        CircularLinkedListArray clonedList = list.Clone();
        Assert.AreEqual(list.Length(), clonedList.Length());
        for (int i = 0; i < list.Length(); i++)
        {
            Assert.AreEqual(list.Get(i), clonedList.Get(i));
        }
    }

    [Test]
    public void Test_Reverse()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        list.Reverse();
        Assert.AreEqual('c', list.Get(0));
        Assert.AreEqual('b', list.Get(1));
        Assert.AreEqual('a', list.Get(2));
    }

    [Test]
    public void Test_FindFirst()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('a');
        Assert.AreEqual(0, list.FindFirst('a'));
    }

    [Test]
    public void Test_FindLast()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('a');
        Assert.AreEqual(2, list.FindLast('a'));
    }

    [Test]
    public void Test_Clear()
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        list.Append('a');
        list.Append('b');
        list.Append('c');
        list.Clear();
        Assert.AreEqual(0, list.Length());
    }

    [Test]
    public void Test_Extend()
    {
        CircularLinkedListArray list1 = new CircularLinkedListArray();
        list1.Append('a');
        list1.Append('b');
        list1.Append('c');

        CircularLinkedListArray list2 = new CircularLinkedListArray();
        list2.Append('d');
        list2.Append('e');
        list2.Append('f');

        list1.Extend(list2);
        Assert.AreEqual(6, list1.Length());
        Assert.AreEqual('d', list1.Get(3));
        Assert.AreEqual('e', list1.Get(4));
        Assert.AreEqual('f', list1.Get(5));
    }
}