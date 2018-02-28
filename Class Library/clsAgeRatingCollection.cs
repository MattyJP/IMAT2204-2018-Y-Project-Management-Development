using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Library
{
    public class clsAgeRatingCollection
    {
        //Public constructor for the class
        public clsAgeRatingCollection()
        {
            //Create an instance of the age rating class to store an age rating
            clsAgeRating AnAgeRating = new clsAgeRating();
            //Set the age rating to U
            AnAgeRating.AgeRatingTitle = "U";
            //Add the age rating to the private list of age ratings
            mAgeRatingList.Add(AnAgeRating);
            //Re-initialise the AnAgeRating object to accept a new item
            AnAgeRating = new clsAgeRating();
            //Set the age rating to PG
            AnAgeRating.AgeRatingTitle = "PG";
            //Add the second age rating to the private list of age ratings
            mAgeRatingList.Add(AnAgeRating);
            //The private list now contains two genres
        }

        //Private data member for the AgeRatingList list
        private List<clsAgeRating> mAgeRatingList = new List<clsAgeRating>();

        //Public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAgeRatingList.Count;
            }
            set
            {
                //TODO
            }
        }

        //Public property for AgeRatingList
        public List<clsAgeRating> AgeRatingList
        {
            get
            {
                //Return the private data member
                return mAgeRatingList;
            }
            set
            {
                //Assign the incoming value to the private data member
                mAgeRatingList = value;
            }
        }

    }
}