using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LinkedListDemo
{
    sealed class TypeSingleLinkedList<T> : SingleLinkedList
        where T : IEquatable<T>
    {
        public T Value { get; private set; }
        public TypeSingleLinkedList(T value, SingleLinkedList next) : base(next)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString() + $" {(next != null ? next.ToString() : String.Empty)}";
        }

    }
}
