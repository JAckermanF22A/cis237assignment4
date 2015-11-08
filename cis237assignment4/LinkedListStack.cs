using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedListStack<T>
    {
        public class StackNode<T>
        {
            public StackNode<T> Tail;
            public T Droid;
        }

        private StackNode<T> currentNode;

        public StackNode<T> lastNode
        {
            get;
            set;
        }

        public LinkedListStack()
        {
            lastNode = null;
        }

        public void Add(T newDroid)
        {
            StackNode<T> node = new StackNode<T>();

            node.Droid = newDroid;

            if(lastNode == null)
            {
                lastNode = node;
            }
            else
            {
                node.Tail = lastNode;
            }

            lastNode = node;
        }

        public T PopOff()
        {
            T returnDroid = lastNode.Droid;
            lastNode = lastNode.Tail;
            

            return returnDroid;
        }
    }
}
