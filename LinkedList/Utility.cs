using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    internal static class Utility
    {

        #region Reverse single linked list.

        public static void ReverseSingleLinkedList<T>(TypeSingleLinkedList<T> linkedList)
                    where T : IEquatable<T>
        {
            if (linkedList == null || linkedList.Next == null)
            {
                return;
            }
            var middle = linkedList;
            var beg = linkedList;
            var end = linkedList.Next;
            while (end != null)
            {
                middle.Next = end.Next as TypeSingleLinkedList<T>;
                end.Next = beg;
                beg = end as TypeSingleLinkedList<T>;
                end = middle.Next;
            }
            linkedList = beg;
        }

        #endregion

        #region Combine sorted single linked list.

        public static TypeSingleLinkedList<T> CombineSingleLinkedList<T>(TypeSingleLinkedList<T> listA, TypeSingleLinkedList<T> listB)
                where T : IEquatable<T>, IComparable<T>
        {
            if (listA == null || listB == null) return listA != null ? listA : listB;
            TypeSingleLinkedList<T> head = null;
            TypeSingleLinkedList<T> mid = null;
            TypeSingleLinkedList<T> end = null;
            while (listA != null && listB != null)
            {
                if (listA.Value.CompareTo(listB.Value) < 0)
                {
                    mid = listA;
                    listA = listA.Next as TypeSingleLinkedList<T>;
                }
                else if (listA.Value.CompareTo(listB.Value) == 0)
                {
                    mid = listA;
                    listA = listA.Next as TypeSingleLinkedList<T>;
                    listB = listB.Next as TypeSingleLinkedList<T>;
                }
                else
                {
                    mid = listB;
                    listB = listB.Next as TypeSingleLinkedList<T>;
                }
                if (head == null)
                {
                    head = mid;
                    end = head;
                }
                else if (end.Value.CompareTo(mid.Value) != 0)
                {
                    end.Next = mid;
                    end = end.Next as TypeSingleLinkedList<T>;
                }
            }
            end.Next = listA == null ? listB : listA;
            return head;
        }

        #endregion

        #region  Delete reciprocal element.

        public static TypeSingleLinkedList<T> DeleteReciprocalElement<T>(TypeSingleLinkedList<T> list, int n)
            where T : IEquatable<T>
        {
            if (list == null || n < 1)
            {
                return null;
            }
            int length = 0;
            var temp = list;
            while (temp != null)
            {
                length += 1;
                temp = temp.Next as TypeSingleLinkedList<T>;
            }
            var index = length - n;
            if (index < 0)
            {
                return null;
            }
            else if (index == 0)
            {
                list = list.Next as TypeSingleLinkedList<T>;
            }
            else
            {
                temp = list;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next as TypeSingleLinkedList<T>;
                }
                if (temp.Next != null && temp.Next.Next == null)
                {
                    temp.Next = null;
                }
                else
                {
                    temp.Next = temp.Next.Next;
                }
            }
            return list;
        }

        #endregion

        #region Middle link.

        public static TypeSingleLinkedList<T> GetMiddleLinkList<T>(TypeSingleLinkedList<T> list, bool betweenUpper = true)
            where T : IEquatable<T>
        {
            var slowPointer = list;
            var fastPointer = list;
            if (fastPointer == null)
            {
                return null;
            }
            if (fastPointer != null && fastPointer.Next == null)
            {
                return slowPointer;
            }
            if (fastPointer != null && fastPointer.Next != null && fastPointer.Next.Next == null)
            {
                return slowPointer;
            }
            while (fastPointer.Next != null && fastPointer.Next.Next != null)
            {
                slowPointer = slowPointer.Next as TypeSingleLinkedList<T>;
                fastPointer = fastPointer.Next.Next as TypeSingleLinkedList<T>;
            }
            //list的长度是偶数时,会有中上位或者中下位的差异,如果list是奇数则没有这种差异
            //此时list长度是偶数
            if (fastPointer.Next != null && !betweenUpper)
            {
                slowPointer = slowPointer.Next as TypeSingleLinkedList<T>;
            }
            return slowPointer;
        }
        #endregion
    }
}
