using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericLinkedList<T>
    {
        private GenericNode<T> currentNode;

        private GenericNode<T> lastNode;

        public GenericNode<T> headNode
        {
            get;
            set;
        }

        public GenericLinkedList()
        {
            headNode = null;
        }

        public void Add(T newDroid)
        {
            GenericNode<T> node = new GenericNode<T>();

            node.Droid = newDroid;

            if(headNode == null)
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
