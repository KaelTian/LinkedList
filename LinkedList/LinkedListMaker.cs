namespace LinkedListDemo
{
    internal static class LinkedListMaker
    {

        public static TypeSingleLinkedList<Char> GetNotPlalindromeSingleLinkedList()
        {
            var tailNode = new TypeSingleLinkedList<Char>('h', null);
            var node1 = new TypeSingleLinkedList<Char>('a', tailNode);
            var node2 = new TypeSingleLinkedList<Char>('s', node1);
            var node3 = new TypeSingleLinkedList<Char>('q', node2);
            var node4 = new TypeSingleLinkedList<Char>('a', node3);
            var headNode = new TypeSingleLinkedList<Char>('z', node4);

            return headNode;
        }

        public static TypeSingleLinkedList<Char> GetPlalindromeSingleLinkedList()
        {
            var tailNode = new TypeSingleLinkedList<Char>('h', null);
            var node1 = new TypeSingleLinkedList<Char>('a', tailNode);
            var node2 = new TypeSingleLinkedList<Char>('s', node1);
            var node3 = new TypeSingleLinkedList<Char>('q', node2);
            var node4 = new TypeSingleLinkedList<Char>('a', node3);
            var node5 = new TypeSingleLinkedList<Char>('z', node4);
            var node6 = new TypeSingleLinkedList<Char>('a', node5);
            var node7 = new TypeSingleLinkedList<Char>('q', node6);
            var node8 = new TypeSingleLinkedList<Char>('s', node7);
            var node9 = new TypeSingleLinkedList<Char>('a', node8);
            var headNode = new TypeSingleLinkedList<Char>('h', node9);
            return headNode;
        }

        #region Sorted Single linked list.

        public static TypeSingleLinkedList<Int32> GetSortedInt32SingleLinkedList1()
        {
            var tailNode = new TypeSingleLinkedList<Int32>(101, null);
            var node1 = new TypeSingleLinkedList<Int32>(9, tailNode);
            var node2 = new TypeSingleLinkedList<Int32>(8, node1);
            var node3 = new TypeSingleLinkedList<Int32>(3, node2);
            var node4 = new TypeSingleLinkedList<Int32>(2, node3);
            var headNode = new TypeSingleLinkedList<Int32>(1, node4);

            return headNode;
        }

        public static TypeSingleLinkedList<Int32> GetSortedInt32SingleLinkedList2()
        {
            var tailNode = new TypeSingleLinkedList<Int32>(14, null);
            var node0 = new TypeSingleLinkedList<Int32>(9, tailNode);
            var node1 = new TypeSingleLinkedList<Int32>(9, node0);
            var node2 = new TypeSingleLinkedList<Int32>(8, node1);
            var node3 = new TypeSingleLinkedList<Int32>(6, node2);
            var node4 = new TypeSingleLinkedList<Int32>(5, node3);
            var headNode = new TypeSingleLinkedList<Int32>(4, node4);

            return headNode;
        }

        #endregion

    }
}
