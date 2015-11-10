using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Jacob Ackerman
//Although it's weird signing my name to this when most of the code here was actually written by you

//Actually I don't know if I need to put my name in here


namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);

            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Creates a merge sort class.
            MergeSort mergeSort = new MergeSort();

            //Example droids for use in testing the program.
            //9 droids to make sure it works even with odd numbered arrays/lists.
            droidCollection.Add("Carbonite", "Utility", "Bronze", true, true, true);
            droidCollection.Add("Carbonite", "Protocol", "Bronze", 3);
            droidCollection.Add("Carbonite", "Astromech", "Bronze", true, true, true, true, 5);
            droidCollection.Add("Carbonite", "Janitor", "Bronze", true, true, true, true, true);

            droidCollection.Add("Carbonite", "Utility", "Silver", true, true, true);
            droidCollection.Add("Carbonite", "Protocol", "Silver", 3);
            droidCollection.Add("Carbonite", "Astromech", "Silver", true, true, true, true, 5);
            droidCollection.Add("Carbonite", "Janitor", "Silver", true, true, true, true, true);

            droidCollection.Add("Vanadium", "Protocol", "Gold", 6);






            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 5, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;
                    //Choose to sort the list by droid type
                    case 3:
                        droidCollection.SortByDroid();
                        break;
                    //Chose to sort the list by droid total price
                    case 4:
                        droidCollection.SortByPrice();
                        break;
                }
                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();
            }


        }
    }
}
