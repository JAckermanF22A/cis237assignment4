using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedListQueue<T>
    {
        public GenericNode<T> headNode;
        public GenericNode<T> lastNode;

        public void Enqueue(T newDroid)
        {
            GenericNode<T> node = new GenericNode<T>();

            node.Droid = newDroid;

            if (headNode == null)
            {
                headNode = node;
            }
            else
            {
                lastNode.Next = node;
            }

            lastNode = node;
        }

        public T Dequeue()
        {
            T returnDroid = headNode.Droid;
            headNode = headNode.Next;

            return returnDroid;
        }
    }
}
