namespace LinkedListDemo
{
    internal class SingleLinkedList
    {

        protected SingleLinkedList next;

        public SingleLinkedList Next { get { return next; } set { next = value; } }

        public SingleLinkedList(SingleLinkedList next)
        {
            this.next = next;
        }

    }
}
