using System;
namespace Class_Library
{
    public class clsScreening
    {
        //Private data member for the ScreeningID property
        private Int32 mScreeningID;
        //Private data member for the FilmID
        private Int32 mFilmID;
        //Private data member for the ScreenID
        private Int32 mScreenID;
        //private data member for the Screening Cost
        private decimal mScreeningCost;
        //Private data member for the Screening date
        private DateTime mScreeningDate;
        //Private data member for the Cancelled property
        private bool mCancelled;


        public int ScreeningID
        {
            get
            {
                //Return the private data
                return mScreeningID;
            }
            set
            {
                //Set the value of the private data member
                mScreeningID = value;
            }
        }

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

        public int ScreenID
        {
            get
            {
                //Return the private data
                return mScreenID;
            }
            set
            {
                //Set the value of the private data member
                mScreenID = value;
            }
        }

        public decimal ScreeningCost
        {
            get
            {
                //Return the private data
                return mScreeningCost;
            }
            set
            {
                //Set the value of the private data member
                mScreeningCost = value;
            }
        }

        public DateTime ScreeningDate
        {
            get
            {
                //Return the private data
                return mScreeningDate;
            }
            set
            {
                //Set the value of the private data member
                mScreeningDate = value;
            }
        }

        public Boolean Cancelled
        {
            get
            {
                //Return the private data
                return mCancelled;
            }
            set
            {
                //Set the value of the private data member
                mCancelled = value;
            }
        }

        public bool Find(Int32 ScreeningID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Screening title to search for
            DB.AddParameter("@ScreeningID", ScreeningID);
            //Execute the stored procedure
            DB.Execute("sproc_tblScreening_FilterByCancelled");
            //If one record is found (There should be either one or zero
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mScreeningID = Convert.ToInt32(DB.DataTable.Rows[0]["ScreeningID"]);
                mFilmID = Convert.ToInt32(DB.DataTable.Rows[0]["FilmID"]);
                mScreenID = Convert.ToInt32(DB.DataTable.Rows[0]["ScreenID"]);
                mScreeningCost = Convert.ToDecimal(DB.DataTable.Rows[0]["ScreeningCost"]);
                mScreeningDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ScreeningDate"]);
                mCancelled = Convert.ToBoolean(DB.DataTable.Rows[0]["Cancelled"]);
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

        public string Valid(string filmID, string screenID, string screeningCost, string screeningDate)
        {
            //Create a string variable to store the error
            string Error = "";
            //Create a temporary variable to store date values
            DateTime DateTemp;
            //If the FilmID is blank
            if (filmID.Length == 0)
            {
                //Record the error
                Error = Error + "The Film ID may not be blank : ";
            }
            //If the ScreenID is blank
            if (screenID.Length == 0)
            {
                //Record the error
                Error = Error + "The Screen ID must not be blank : ";
            }
            //If the Screening Cost is blank
            if (screeningCost.ToString().Length == 0)
            {
                //Record the error
                Error = Error + "The Screening Cost may not be blank : ";
            }
            //Tries to check of the ScreeningDate data is valid
            try
            {
                //Copy the ScreeningDate variable to the DateTemp Variable
                DateTemp = Convert.ToDateTime(screeningDate);
                if (DateTemp < DateTime.Now)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past : ";
                }
            }
            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date : ";
            }
            //Return any error messages
            return Error;
        }
    }
}