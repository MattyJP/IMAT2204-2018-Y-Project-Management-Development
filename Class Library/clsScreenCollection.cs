using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsScreenCollection
    {
        //Public constructor for the class
        public clsScreenCollection()
        {
            //Create an instance of the screen class to store a screen
            clsScreen AScreen = new clsScreen();
            //Set the capacity to 60
            AScreen.Capacity = 60;
            //Add the screen to the private list of screens
            mScreenList.Add(AScreen);
            //Re-initialise the AScreen object to accept a new item
            AScreen = new clsScreen();
            //Set the capacity to 55
            AScreen.Capacity = 55;
            //Add the second screen to the private list of screens
            mScreenList.Add(AScreen);
            //The private list now contains two genres
        }

        //Private data member for the ScreenList list
        private List<clsScreen> mScreenList = new List<clsScreen>();

        //Public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mScreenList.Count;
            }
            set
            {
                //TODO
            }
        }

        //Public property for ScreenList
        public List<clsScreen> ScreenList
        {
            get
            {
                //Return the private data member
                return mScreenList;
            }
            set
            {
                //Assign the incoming value to the private data member
                mScreenList = value;
            }
        }

    }
}