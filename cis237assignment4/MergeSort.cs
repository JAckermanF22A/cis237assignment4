using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        //A method for sorting a specific section of a passed in array depending on it's start and end point.
        public void arrayMerge(IComparable[] array, int start, int middle, int end)
        {
            //An temporary array to hold the newly sorted section
            IComparable[] tempArray = new IComparable[end - start+1];

            
            int i = start;      //Indicates the start of the section we'll walk through
            int j = middle + 1; //Indicates the middle of the section
            int k = 0;          //For use to indicate the position in the temp array.


            while(i <= middle && j <= end)
            {
                //If the array position i is less than position j as determined by the CompareTo then place position i into the slot k of the temp array
                if(array[i].CompareTo(array[j]) < 0)
                {
                    tempArray[k] = array[i];
                    i++; //position i has been positioned, so we can increment to a new value here.
                    k++;
                }
                //else since j is greater than i place j in the temp array
                else
                {
                    tempArray[k] = array[j];
                    j++; //Same as when we set position i, only with position j this time
                    k++;
                }

            }

            //Walks through to implement any droids in a position lower than or equal to the mid point not already implemented into the temp array.
            while(i<=middle)
            {
                tempArray[k] = array[i];
                k++;
                i++;
            }

            //Same as above only with droids above the mid point
            while (j <= end)
            {
                tempArray[k] = array[j];
                k++;
                j++;
            }
 
            //Walk through the temp array, assigning the values to the actual array.
            k=0;
            i=start;
            while (k < tempArray.Length && i <= end)
            {
                array[i] = tempArray[k];
                i++;
                k++;
            }
        }

        //The actual merge portion. Chops the array in half again and again until it's in small chunks, then sorts the chunks until they form a united and sorted array.
        public void mergesort(IComparable[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                mergesort(array, start, middle); //Chops the array in half and uses the front end of that half. 
                mergesort(array, middle + 1, end); //Chops the array in half and uses the end half.
                arrayMerge(array, start, middle, end); //Sends whichever the current section in use is to the sorting method
            }
        }
    }
}
