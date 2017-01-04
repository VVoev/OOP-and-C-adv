using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Common_Type_System.Implementing_IEnumerable
{
    class LinkedList<T> : IEnumerable<T>
    {

        public T Value { get; set;}
        public LinkedList<T> NextNode { get; private set; }

        public LinkedList(T value, LinkedList<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedList<T> currentNode = this;
            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }


    }
}
