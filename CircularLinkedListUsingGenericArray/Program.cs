class Program
{
    static void Main(string[] args)
    {
        CircularLinkedListArray list = new CircularLinkedListArray();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Circular Linked List");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Append an element");
            Console.WriteLine("2. Insert an element");
            Console.WriteLine("3. Delete an element");
            Console.WriteLine("4. Delete all occurrences of an element");
            Console.WriteLine("5. Get an element");
            Console.WriteLine("6. Find first occurrence of an element");
            Console.WriteLine("7. Find last occurrence of an element");
            Console.WriteLine("8. Clear the list");
            Console.WriteLine("9. Display the list");
            Console.WriteLine("10. Reverse the list");
            Console.WriteLine("0. Exit");
            Console.WriteLine("--------------------");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            char element;
            int index;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the element to append: ");
                    element = Convert.ToChar(Console.ReadLine());
                    list.Append(element);
                    break;
                case 2:
                    Console.Write("Enter the element to insert: ");
                    element = Convert.ToChar(Console.ReadLine());
                    Console.Write("Enter the index: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    list.Insert(element, index);
                    break;
                case 3:
                    Console.Write("Enter the index of the element to delete: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    list.Delete(index);
                    break;
                case 4:
                    Console.Write("Enter the element to delete all occurrences of: ");
                    element = Convert.ToChar(Console.ReadLine());
                    list.DeleteAll(element);
                    break;
                case 5:
                    Console.Write("Enter the index of the element to get: ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Element: " + list.Get(index));
                    break;
                case 6:
                    Console.Write("Enter the element to find the first occurrence of: ");
                    element = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("First occurrence: " + list.FindFirst(element));
                    break;
                case 7:
                    Console.Write("Enter the element to find the last occurrence of: ");
                    element = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Last occurrence: " + list.FindLast(element));
                    break;
                case 8:
                    list.Clear();
                    break;
                case 9:
                    DisplayList(list);
                    break;
                case 10:
                    list.Reverse();
                    break;
                case 0:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void DisplayList(CircularLinkedListArray list)
    {
        Console.WriteLine("List: ");
        int length = list.Length();
        for (int i = 0; i < length; i++)
        {
            Console.Write(list.Get(i) + " ");
        }
        Console.WriteLine();
    }
}