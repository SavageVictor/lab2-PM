using System;
using NUnit.Framework;

[TestFixture]
public class CircularLinkedListTests
{
    [Test]
    public void LengthTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        Assert.AreEqual(0, list.Length());

        list.Append('A');
        Assert.AreEqual(1, list.Length());

        list.Append('B');
        Assert.AreEqual(2, list.Length());

        list.Delete(1);
        Assert.AreEqual(1, list.Length());

        list.Clear();
        Assert.AreEqual(0, list.Length());
    }

    [Test]
    public void AppendTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        Assert.AreEqual('A', list.Get(0));
        Assert.AreEqual('B', list.Get(1));
        Assert.AreEqual('C', list.Get(2));
    }

    [Test]
    public void InsertTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        list.Insert('D', 1);

        Assert.AreEqual('A', list.Get(0));
        Assert.AreEqual('D', list.Get(1));
        Assert.AreEqual('B', list.Get(2));
        Assert.AreEqual('C', list.Get(3));
    }

    [Test]
    public void DeleteTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        char deleted = list.Delete(1);

        Assert.AreEqual('B', deleted);
        Assert.AreEqual(2, list.Length());
        Assert.AreEqual('A', list.Get(0));
        Assert.AreEqual('C', list.Get(1));
    }

    [Test]
    public void DeleteAllTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('A');
        list.Append('C');
        list.Append('A');

        list.DeleteAll('A');

        Assert.AreEqual(2, list.Length());
        Assert.AreEqual('B', list.Get(0));
        Assert.AreEqual('C', list.Get(1));
    }

    [Test]
    public void GetTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        Assert.AreEqual('A', list.Get(0));
        Assert.AreEqual('B', list.Get(1));
        Assert.AreEqual('C', list.Get(2));
    }

    [Test]
    public void CloneTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        CircularLinkedList clonedList = list.Clone();

        Assert.AreNotSame(list, clonedList);
        Assert.AreEqual(list.Length(), clonedList.Length());
        Assert.AreEqual(list.Get(0), clonedList.Get(0));
        Assert.AreEqual(list.Get(1), clonedList.Get(1));
        Assert.AreEqual(list.Get(2), clonedList.Get(2));
    }

    [Test]
    public void ReverseTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        list.Reverse();

        Assert.AreEqual('C', list.Get(0));
        Assert.AreEqual('B', list.Get(1));
        Assert.AreEqual('A', list.Get(2));
    }

    [Test]
    public void FindFirstTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('A');
        list.Append('C');
        list.Append('A');

        Assert.AreEqual(0, list.FindFirst('A'));
        Assert.AreEqual(1, list.FindFirst('B'));
        Assert.AreEqual(3, list.FindFirst('C'));
        Assert.AreEqual(-1, list.FindFirst('D'));
    }

    [Test]
    public void FindLastTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('A');
        list.Append('C');
        list.Append('A');

        Assert.AreEqual(4, list.FindLast('A'));
        Assert.AreEqual(1, list.FindLast('B'));
        Assert.AreEqual(3, list.FindLast('C'));
        Assert.AreEqual(-1, list.FindLast('D'));
    }

    [Test]
    public void ClearTest()
    {
        CircularLinkedList list = new CircularLinkedList();
        list.Append('A');
        list.Append('B');
        list.Append('C');

        list.Clear();

        Assert.AreEqual(0, list.Length());
    }

    [Test]
    public void ExtendTest()
    {
        CircularLinkedList list1 = new CircularLinkedList();
        list1.Append('A');
        list1.Append('B');
        list1.Append('C');

        CircularLinkedList list2 = new CircularLinkedList();
        list2.Append('D');
        list2.Append('E');
        list2.Append('F');

        list1.Extend(list2);

        Assert.AreEqual(6, list1.Length());
        Assert.AreEqual('A', list1.Get(0));
        Assert.AreEqual('B', list1.Get(1));
        Assert.AreEqual('C', list1.Get(2));
        Assert.AreEqual('D', list1.Get(3));
        Assert.AreEqual('E', list1.Get(4));
        Assert.AreEqual('F', list1.Get(5));
    }
}