using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class LinkedListStack<T>
    {
        //A class that acts as a node for holding droids
        public class StackNode<T>
        {
            //Because it's a First-in-last-out structure the linked list uses a "tail" instead of a "next" value.
            public StackNode<T> Tail;
            public T Droid;
        }

        //Properties for pointing to the last node in the list.
        public StackNode<T> lastNode
        {
            get;
            set;
        }

        //The constructor, sets lastNode to null since the list is empty
        public LinkedListStack()
        {
            lastNode = null;
        }

        //Method for adding Droids to the list/stack
        public void Add(T newDroid)
        {
            StackNode<T> node = new StackNode<T>();

            node.Droid = newDroid;

            //If the list has no entries, making lastNode null, then it sets lastNode as the current node.
            if(lastNode == null)
            {
                lastNode = node;
            }
            //Else set the current Node's tail to the, for now, current LastNode
            else
            {
                node.Tail = lastNode;
            }

            //Sets the last node to the new node.
            lastNode = node;
        }

        //"Pops" a droid off the end/top of the list/stack and returns that droid.
        public T PopOff()
        {
            T returnDroid = lastNode.Droid;
            lastNode = lastNode.Tail; //Sets the last node to the tail of the current last node, effectively removing the current last node from the list for eventual removal by the
                                      //garbage collector.

            return returnDroid;
        }
    }
}
