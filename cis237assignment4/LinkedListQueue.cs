using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedListQueue<T>
    {

        public GenericNode<T> headNode; //First-in-first-out, so we use a head node
        public GenericNode<T> lastNode;

        //Adds a droid to the queue/list
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

        //Removes a droid from the queue/list
        public T Dequeue()
        {
            T returnDroid = headNode.Droid;
            headNode = headNode.Next;

            return returnDroid;
        }
    }
}
