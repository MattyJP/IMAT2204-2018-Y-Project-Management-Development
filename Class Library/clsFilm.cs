using System;
namespace Class_Library
{
    public class clsFilm
    {
        //Private data member for the FilmID property
        private Int32 mFilmID;
        //Private data member for the Title
        private string mTitle;
        //Private data member for the duration
        private Int32 mDuration;
        //Private data member for the Age Rating ID
        private Int32 mAgeRatingID;
        //Private data member for the Genre ID
        private Int32 mGenreID;
        public int FilmID
        {
            get
            {
                //Return the private data
                return mFilmID;
            }
            set
            {
                //Set the value of the private data member
                mFilmID = value;
            }
        }

        public string Title
        {
            get
            {
                //Return the private data
                return mTitle;
            }
            set
            {
                //Set the value of the private data member
                mTitle = value;
            }
        }

        public int Duration
        {
            get
            {
                //Return the private data
                return mDuration;
            }
            set
            {
                //Set the value of the private data member
                mDuration = value;
            }
        }

        public int AgeRatingID
        {
            get
            {
                //Return the private data
                return mAgeRatingID;
            }
            set
            {
                //Set the value of the private data member
                mAgeRatingID = value;
            }
        }

        public int GenreID
        {
            get
            {
                //Return the private data
                return mGenreID;
            }
            set
            {
                //Set the value of the private data member
                mGenreID = value;
            }
        }

        public bool Find(Int32 FilmID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Film title to search for
            DB.AddParameter("@FilmID", FilmID);
            //Execute the stored procedure
            DB.Execute("sproc_tblFilm_FilterByTitle");
            //If one record is found (There should be either one or zero
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mFilmID = Convert.ToInt32(DB.DataTable.Rows[0]["FilmID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mDuration = Convert.ToInt32(DB.DataTable.Rows[0]["Duration"]);
                mAgeRatingID = Convert.ToInt32(DB.DataTable.Rows[0]["AgeRatingID"]);
                mGenreID = Convert.ToInt32(DB.DataTable.Rows[0]["GenreID"]);
                //Return that everything worked OK
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }

        public string Valid(string title, string duration, string ageRatingID, string genreID)
        {
            //Create a string variable to store the error
            string Error = "";
            //If the Title is blank
            if (Title.Length == 0)
            {
                //Record the error
                Error = Error + "The Title may not be blank : ";
            }
            //If the title is greater than 50 characters
            if (Title.Length > 50)
            {
                //Record the error
                Error = Error + "The title must be less than 50 characters : ";
            }
            //If the Title is blank
            if (Duration.ToString().Length == 0)
            {
                //Record the error
                Error = Error + "The duration may not be blank : ";
            }
            //If the title is greater than 50 characters
            if (Duration.ToString().Length > 4)
            {
                //Record the error
                Error = Error + "The duration must be less than 4 characters : ";
            }
            //Return any error messages
            return Error;
        }
    }
}